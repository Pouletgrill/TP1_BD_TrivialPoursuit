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
            //-- À remplacer par du code de BD
            Categories.Add("Science");
            Categories.Add("Histoire");
            Categories.Add("Geographie");
            Categories.Add("Cinéma");

            for (int i = 0; i < nbJoueurs; i++)
            {
                Joueur joueur = new Joueur("Joueur " + (i + 1).ToString(), i);
                Joueurs.Add(joueur);
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            Connecter();
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

        public void ProchainJoueur()
        {
            Courant = (Courant + 1) % Joueurs.Count;
            LBL_Joueur.Text = Joueurs[Courant].Alias;

            PoserQuestion();
        }

        private void PigerQuestion(int categorie)
        {
            List<Reponse> list = new List<Reponse>();

            //-- À remplacer par du code de BD
            switch (categorie)
            {
                case 0:
                    list.Add(new Reponse("A", "1840", false));
                    list.Add(new Reponse("B", "1492", true));
                    list.Add(new Reponse("C", "1867", false));
                    list.Add(new Reponse("D", "1931", false));

                    QuestionPigee = new Question("Q", "En quelle année Cristophe Colomb a-t'il découvert l'Amérique", "H", list);
                    break;
                case 1:
                    list.Add(new Reponse("A", "P", false));
                    list.Add(new Reponse("B", "T", false));
                    list.Add(new Reponse("C", "K", true));
                    list.Add(new Reponse("D", "S", false));

                    QuestionPigee = new Question("Q", "Symbole chimique du potassium", "S", list);
                    break;
                case 2:
                    list.Add(new Reponse("A", "Berlin", true));
                    list.Add(new Reponse("B", "Hamburg", false));
                    list.Add(new Reponse("C", "Frankfurt", false));
                    list.Add(new Reponse("D", "Stuttgart", false));

                    QuestionPigee = new Question("Q", "Capitale de l'Allemagne", "G", list);
                    break;
                case 3:
                    list.Add(new Reponse("A", "Jim Carrey", false));
                    list.Add(new Reponse("B", "Tom Cruise", false));
                    list.Add(new Reponse("C", "Brad Pitt", false));
                    list.Add(new Reponse("D", "Nicolas Cage", true));

                    QuestionPigee = new Question("Q", "Meilleur acteur ever", "C", list);
                    break;
            }
        }

        private void PoserQuestion()
        {
            Random rnd = new Random();
            int categorie = rnd.Next(4);
            PigerQuestion(categorie);

            TB_Question.Text = QuestionPigee.Texte + " ?";
            RB_Rep1.Text = QuestionPigee.Reponses[0].Texte;
            RB_Rep2.Text = QuestionPigee.Reponses[1].Texte;
            RB_Rep3.Text = QuestionPigee.Reponses[2].Texte;
            RB_Rep4.Text = QuestionPigee.Reponses[3].Texte;
            LBL_Result.Text = "";
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
                ProchainJoueur();
                ((Button)sender).Text = "Répondre";
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

        private void TournerRoulette()
        {
            Random rand = new Random();
            int rnd = rand.Next(Categories.Count * 2) + Categories.Count;
            int indexCouleur = 0;

            Color[] colors = new Color[5];
            colors[0] = Properties.Settings.Default.CatColor_AuChoix;
            colors[1] = Properties.Settings.Default.CatColor_Science;
            colors[2] = Properties.Settings.Default.CatColor_Histoire;
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
        }

        private void PN_Roulette_MouseClick(object sender, MouseEventArgs e)
        {
            PN_Roulette.Enabled = false;
            TournerRoulette();
            PN_Roulette.Enabled = true;
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
