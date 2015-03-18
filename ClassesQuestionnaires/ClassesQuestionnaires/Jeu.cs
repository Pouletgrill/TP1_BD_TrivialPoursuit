﻿using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesQuestionnaires
{
    public partial class Jeu : Form
    {
        List<Joueur> Joueurs;
        int Courant;
        Question QuestionPigee;

        List<String> Categories;

        private static String orclUser = "riouxfra";
        public String connectionString = "Data Source=(DESCRIPTION="    // ========== TO MOVE =========
                               + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                               + "(HOST=205.237.244.251)(PORT=1521)))"
                               + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)));"
                               + "User Id=" + orclUser + ";Password=ORACLE1";

        public OracleConnection connection;     // ========== TO MOVE =========

        public Jeu(int nbJoueurs)
        {
            InitializeComponent();
            Joueurs = new List<Joueur>();
            Courant = -1; // Au form load, on call ProchainJoueur qui fait +1 donc 0

            Categories = new List<string>();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Connecter();
            ResetScores();
            ChargerJoueur("Walase", 0);
            ChargerJoueur("GroMite", 1);
            ChargerCategories();
            ProchainJoueur();
        }

        private void Connecter() // ========== TO MOVE =========
        {
            connection = new OracleConnection(connectionString);
            connection.ConnectionString = connectionString;

            try
            {
                connection.Open();
                //MessageBox.Show(connection.State.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connection");
            }
        }

        private void ChargerCategories()
        {
            try
            {
                OracleCommand inserer = new OracleCommand("INSERTION", connection);
                inserer.CommandText = "PKG_GESTION.LISTER_CATEGORIES";
                inserer.CommandType = CommandType.StoredProcedure;

                OracleParameter pResultat = new OracleParameter("PRESULTAT", OracleDbType.RefCursor);
                pResultat.Direction = ParameterDirection.ReturnValue;
                inserer.Parameters.Add(pResultat);

                OracleDataReader reader = inserer.ExecuteReader();

                while (reader.Read())
                {
                    Categories.Add(reader.GetString(0));
                }
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message);
            }
        }

        private void ChargerJoueur(String Joueur, int ordre)
        {
            try
            {
                OracleCommand charger = new OracleCommand("CHARGER", connection);
                charger.CommandType = CommandType.StoredProcedure;
                charger.CommandText = "PKG_JEU.CHARGERJOUEUR";

                OracleParameter pJoueur = new OracleParameter("PJOUEUR", OracleDbType.Varchar2, 30);
                pJoueur.Direction = ParameterDirection.Input;
                pJoueur.Value = Joueur;
                charger.Parameters.Add(pJoueur);

                charger.ExecuteNonQuery();

                Joueurs.Add(new Joueur(Joueur, ordre));
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message);
            }

        }

        private void ResetScores()
        {
            try
            {
                OracleCommand reset = new OracleCommand("RESET", connection);
                reset.CommandType = CommandType.StoredProcedure;
                reset.CommandText = "PKG_JEU.RESETSCORES";
                reset.ExecuteNonQuery();
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message);
            }
        }

        public void ProchainJoueur()
        {
            Courant = (Courant + 1) % Joueurs.Count;
            LBL_Joueur.Text = Joueurs[Courant].Alias;
            AfficherScore();
        }

        private void PigerQuestion(char categorie)
        {
            try
            {
                List<Reponse> list = new List<Reponse>();

                OracleCommand piger = new OracleCommand("PIGER", connection);
                piger.CommandText = "PKG_JEU.PIGERQUESTION";
                piger.CommandType = CommandType.StoredProcedure;

                OracleParameter pReponses = new OracleParameter("PREPONSES", OracleDbType.RefCursor);
                pReponses.Direction = ParameterDirection.ReturnValue;
                piger.Parameters.Add(pReponses);

                OracleParameter pCategorie = new OracleParameter("PCATEGORIE", OracleDbType.Varchar2, 10);
                pCategorie.Direction = ParameterDirection.Input;
                pCategorie.Value = categorie.ToString();
                piger.Parameters.Add(pCategorie);

                OracleParameter pQuestion = new OracleParameter("PQUESTION", OracleDbType.Varchar2, 250);
                pQuestion.Direction = ParameterDirection.Output;
                piger.Parameters.Add(pQuestion);

                OracleDataReader reader = piger.ExecuteReader();

                while (reader.Read())
                {
                    bool bonne = (reader.GetString(2) == "1");
                    list.Add(new Reponse(reader.GetString(0), reader.GetString(1), bonne));
                }

                Random rnd = new Random();
                int index = rnd.Next(0, list.Count);

                Reponse temp = list[index];
                list[index] = list[0];
                list[0] = temp;

                QuestionPigee = new Question("Q", pQuestion.Value.ToString(), categorie.ToString(), list);
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message);
            }
        }

        private void PoserQuestion()
        {
            char categorie = TournerRoulette()[0];
            PigerQuestion(categorie);

            TB_Question.Text = QuestionPigee.Texte + " ?";

            RB_Rep1.Text = QuestionPigee.Reponses[0].Texte;
            RB_Rep2.Text = QuestionPigee.Reponses[1].Texte;
            RB_Rep3.Text = QuestionPigee.Reponses[2].Texte;
            RB_Rep4.Text = QuestionPigee.Reponses[3].Texte;
            LBL_Result.Text = "";
            BTN_Action.Enabled = true;
        }

        private void ValiderReponse()
        {
            BTN_Action.Enabled = false;

            if (QuestionPigee.ValiderReponse(Joueurs[Courant].Repondre(PN_Choix)))
            {
                BonneReponse();
            }
            else
            {
                MauvaiseReponse();
            }
            PN_Roulette.Enabled = true;
        }

        private void BonneReponse()
        {
            try
            {
                LBL_Result.Text = "GOOD";
                OracleCommand score = new OracleCommand("SCORE", connection);
                score.CommandType = CommandType.StoredProcedure;
                score.CommandText = "PKG_JEU.BONNEREPONSE";

                OracleParameter pJoueur = new OracleParameter("PJOUEUR", OracleDbType.Varchar2, 30);
                pJoueur.Direction = ParameterDirection.Input;
                pJoueur.Value = Joueurs[Courant].Alias;
                score.Parameters.Add(pJoueur);

                OracleParameter pCategorie = new OracleParameter("PCATEGORIE", OracleDbType.Varchar2, 10);
                pCategorie.Direction = ParameterDirection.Input;
                pCategorie.Value = QuestionPigee.Categorie;
                score.Parameters.Add(pCategorie);

                score.ExecuteNonQuery();
                AfficherScore();
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message);
            }
        }

        private void MauvaiseReponse()
        {
            LBL_Result.Text = "BAD";
            ProchainJoueur();
        }

        private void AfficherScore()
        {
            try
            {
                OracleCommand afficher = new OracleCommand("AFFICHER", connection);
                afficher.CommandType = CommandType.StoredProcedure;
                afficher.CommandText = "PKG_JEU.AFFICHERSCORE";

                OracleParameter pJoueur = new OracleParameter("PJOUEUR", OracleDbType.Varchar2, 30);
                pJoueur.Direction = ParameterDirection.Input;
                pJoueur.Value = Joueurs[Courant].Alias;
                afficher.Parameters.Add(pJoueur);

                OracleParameter pHistoire = new OracleParameter("PHISTOIRE", OracleDbType.Int32);
                pHistoire.Direction = ParameterDirection.Output;
                afficher.Parameters.Add(pHistoire);

                OracleParameter pScience = new OracleParameter("PSCIENCE", OracleDbType.Int32);
                pScience.Direction = ParameterDirection.Output;
                afficher.Parameters.Add(pScience);

                OracleParameter pGeographie = new OracleParameter("PGEOGRAPHIE", OracleDbType.Int32);
                pGeographie.Direction = ParameterDirection.Output;
                afficher.Parameters.Add(pGeographie);

                OracleParameter pCinema = new OracleParameter("PCINEMA", OracleDbType.Int32);
                pCinema.Direction = ParameterDirection.Output;
                afficher.Parameters.Add(pCinema);

                afficher.ExecuteNonQuery();

                LBL_ScoreHistoire.Text = pHistoire.Value.ToString() + "/5";
                LBL_ScoreScience.Text = pScience.Value.ToString() + "/5";
                LBL_ScoreGeographie.Text = pGeographie.Value.ToString() + "/5";
                LBL_ScoreCinema.Text = pCinema.Value.ToString() + "/5";
            }
            catch (OracleException oe)
            {
                MessageBox.Show(oe.Message);
            }
        }

        private void ResetRadioButton()
        {
            foreach (RadioButton rb in PN_Choix.Controls)
            {
                rb.Checked = false;
            }
        }

        private void BTN_Action_Click(object sender, EventArgs e)
        {
            ValiderReponse();
        }

        private void ModifierQuestionButton_Click(object sender, EventArgs e)
        {
            Gestion dlg = new Gestion(connection);
            dlg.ShowDialog();
        }

        private String AfficherChoixCategorie()
        {
            String categorie = null;

            SelectCategorie dlg = new SelectCategorie();
            dlg.Location = this.Location;
            System.Threading.Thread.Sleep(50);
            dlg.ShowDialog();

            categorie = dlg.Categorie;

            return categorie;
        }

        private String TournerRoulette()
        {
            Color[] colors = new Color[5];
            colors[0] = Properties.Settings.Default.CatColor_AuChoix;
            colors[1] = Properties.Settings.Default.CatColor_Histoire;
            colors[2] = Properties.Settings.Default.CatColor_Science;
            colors[3] = Properties.Settings.Default.CatColor_Geographie;
            colors[4] = Properties.Settings.Default.CatColor_Cinema;

            Random rand = new Random();
            int tours = rand.Next(1, 3);
            int rnd = rand.Next(colors.Length);
            rnd += (tours * colors.Length);
            int indexCouleur = 0;


            for (int i = 0; i < rnd; ++i)
            {
                indexCouleur = i % colors.Length;
                PN_Roulette.BackColor = colors[indexCouleur];
                PN_Roulette.Refresh();
                System.Threading.Thread.Sleep(100 + (i * i));
            }

            String categorie = null;
            if (indexCouleur == 0) //Au choix
            {
                categorie = AfficherChoixCategorie();
            }
            else
            {
                categorie = Categories[indexCouleur - 1];
            }

            LBL_Categorie.Text = categorie;

            return categorie;
        }

        private void PN_Roulette_MouseClick(object sender, MouseEventArgs e)
        {
            PN_Roulette.Enabled = false;
            PoserQuestion();
        }

        private void PN_Roulette_MouseEnter(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Hand;
        }

        private void PN_Roulette_MouseLeave(object sender, EventArgs e)
        {
            this.Cursor = Cursors.Arrow;
        }
    }
}
