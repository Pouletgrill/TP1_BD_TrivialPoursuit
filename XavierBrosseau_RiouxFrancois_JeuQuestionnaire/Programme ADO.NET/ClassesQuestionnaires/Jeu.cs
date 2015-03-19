using Oracle.DataAccess.Client;
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
        public OracleConnection connection;
        List<Joueur> Joueurs;
        int Courant;
        Question QuestionPigee;
        List<String> Categories;

        public Jeu(OracleConnection Connexion, List<String> participants)
        {
            InitializeComponent();
            Joueurs = new List<Joueur>();
            Courant = -1; // Au form load, on call ProchainJoueur qui fait +1 donc 0
            connection = Connexion;
            Categories = new List<string>();

            CommencerPartie(participants);
        }

        private void CommencerPartie(List<String> participants)
        {
            ResetScores();
            for (int i = 0; i < participants.Count; ++i)
            {
                ChargerJoueur(participants[i], i);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ChargerCategories();
            ProchainJoueur();
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

        private bool JoueurAGagner()
        {
            OracleCommand gagner = new OracleCommand("GAGNER", connection);
            gagner.CommandType = CommandType.StoredProcedure;
            gagner.CommandText = "PKG_JEU.CATEGORIESRESTANTES";

            OracleParameter pNum = new OracleParameter("PNUM", OracleDbType.Int32);
            pNum.Direction = ParameterDirection.ReturnValue;
            gagner.Parameters.Add(pNum);

            OracleParameter pJoueur = new OracleParameter("PJOUEUR", OracleDbType.Varchar2, 30);
            pJoueur.Direction = ParameterDirection.Input;
            pJoueur.Value = Joueurs[Courant].Alias;
            gagner.Parameters.Add(pJoueur);

            gagner.ExecuteNonQuery();

            return int.Parse(pNum.Value.ToString()) == 0;
        }

        private void PoserQuestion()
        {   
            char categorie = TournerRoulette()[0];
            PigerQuestion(categorie);

            TB_Question.Text = QuestionPigee.Texte;

            RB_Rep1.Text = QuestionPigee.Reponses[0].Texte;
            RB_Rep2.Text = QuestionPigee.Reponses[1].Texte;
            RB_Rep3.Text = QuestionPigee.Reponses[2].Texte;
            RB_Rep4.Text = QuestionPigee.Reponses[3].Texte;
            BTN_Action.Enabled = true;
            
        }

        private void ValiderReponse()
        {
            BTN_Action.Enabled = false;

            if (QuestionPigee.ValiderReponse(Joueurs[Courant].Repondre(PN_Choix)))
            {
                BonneReponse();

                if (JoueurAGagner())
                {
                    MessageBox.Show(Joueurs[Courant].Alias + " a gagné !");
                    this.Close();
                }
            }
            else
            {
                MauvaiseReponse();
            }

            TB_Question.Text = RB_Rep1.Text = RB_Rep2.Text = RB_Rep3.Text = RB_Rep4.Text = "";

            PN_Roulette.Enabled = true;
        }

        private void BonneReponse()
        {
            try
            {
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
            MessageBox.Show("C'est au tour de " + Joueurs[((Courant + 1) % Joueurs.Count)].Alias, "Mauvaise Réponse !");
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
