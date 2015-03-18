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
   public partial class MenuJeu : Form
   {
      public OracleConnection connection;

      private static String orclUser = "riouxfra";
      public String connectionString = "Data Source=(DESCRIPTION="    // ========== TO MOVE =========
                             + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                             + "(HOST=205.237.244.251)(PORT=1521)))"
                             + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)));"
                             + "User Id=" + orclUser + ";Password=ORACLE1";
      public MenuJeu()
      {
         InitializeComponent();
      }

      private void MenuJeu_Load(object sender, EventArgs e)
      {
         Connecter();
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

      private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Gestion dlg = new Gestion(connection);
         dlg.ShowDialog();
      }

      private void BTN_Jouer_Click(object sender, EventArgs e)
      {
         List<String> participant;
         participant = new List<String>();
         participant.Add(TB_Joueur1.Text);
         participant.Add(TB_Joueur2.Text);
         if (TB_Joueur3.Enabled)
         {
            participant.Add(TB_Joueur3.Text);
         }
         if (TB_Joueur4.Enabled)
         {
            participant.Add(TB_Joueur4.Text);
         }
         AjouterJoueur(participant);
         Jeu dlg = new Jeu(connection, participant);
         dlg.ShowDialog();
      }

      private void AjouterJoueur(List<String> participant)
      {
         for (int i = 0; i< participant.Count; i++)
         {
            try
            {
               OracleCommand oracJoueur = new OracleCommand("PKG_GESTION", connection);
               oracJoueur.CommandType = CommandType.StoredProcedure;
               oracJoueur.CommandText = "PKG_GESTION.INSERTIONJOUEUR";

               OracleParameter oraParam = new OracleParameter("NOM", OracleDbType.Varchar2,30);
               oraParam.Direction = ParameterDirection.Input;
               oraParam.Value = participant[i];
               oracJoueur.Parameters.Add(oraParam);

               oracJoueur.ExecuteNonQuery();

            }
            catch (OracleException ex)
            {
               //Too bad
               MessageBox.Show(participant[i] + " existe deja");
            }
         }
      }

      private void numericUpDown1_ValueChanged(object sender, EventArgs e)
      {
         switch ((int)numericUpDown1.Value)
         {
            case 3:
               TB_Joueur4.Enabled = false;
               TB_Joueur3.Enabled = true;
               break;
            case 4:
               TB_Joueur4.Enabled = TB_Joueur3.Enabled = true;               
               break;
            default:
               TB_Joueur4.Enabled = TB_Joueur3.Enabled = false;
               break;
         }
         UpdateValue();
      }

      private void UpdateValue()
      {
         bool valide = TB_Joueur1.Text != "" && TB_Joueur2.Text != "";

         if (valide && numericUpDown1.Value >= 3)
         {
            valide = TB_Joueur3.Text != "";
         }

         if (valide && numericUpDown1.Value >= 4)
         {
            valide = TB_Joueur4.Text != "";
         }

         BTN_Jouer.Enabled = valide;
      }

      private void TB_Joueur1_TextChanged(object sender, EventArgs e)
      {
         UpdateValue();
      }

   }
}
