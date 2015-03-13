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

            for (int i = 0; i < nbJoueurs; i++)
            {
                Joueur joueur = new Joueur("Joueur " + (i + 1).ToString(), i);
                Joueurs.Add(joueur);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Connecter();
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


        public void ProchainJoueur()
        {
            Courant = (Courant + 1) % Joueurs.Count;
            LBL_Joueur.Text = Joueurs[Courant].Alias;
            BTN_Action.Enabled = false;
        }

        private void PigerQuestion(char categorie)
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

            QuestionPigee = new Question("Q", pQuestion.Value.ToString(), categorie.ToString(), list);
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
            if (QuestionPigee.ValiderReponse(Joueurs[Courant].Repondre(PN_Choix)))
            {
                LBL_Result.Text = "GOOD";
            }
            else
            {
                LBL_Result.Text = "BAD";
            }
            PN_Roulette.Enabled = true;
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
            if (((Button)sender).Text == "Répondre")
            {
                ValiderReponse();
                ((Button)sender).Text = "Next";
            }
            else
            {
                ResetRadioButton();
                ((Button)sender).Text = "Répondre";
                ProchainJoueur();
            }

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
            Random rand = new Random();
            int rnd = rand.Next(Categories.Count * 2) + Categories.Count;
            int indexCouleur = 0;

            Color[] colors = new Color[5];
            colors[0] = Properties.Settings.Default.CatColor_AuChoix;
            colors[1] = Properties.Settings.Default.CatColor_Histoire;
            colors[2] = Properties.Settings.Default.CatColor_Science;
            colors[3] = Properties.Settings.Default.CatColor_Geographie;
            colors[4] = Properties.Settings.Default.CatColor_Cinema;

            for (int i = 0; i < rnd; ++i)
            {
                indexCouleur = i % Categories.Count;
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
