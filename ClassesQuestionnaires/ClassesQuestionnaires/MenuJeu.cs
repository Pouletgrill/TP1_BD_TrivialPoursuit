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
         List<String> gion;
         gion = new List<String>();
         gion.Add("salut");
         Jeu dlg = new Jeu(connection,gion);
      }

   }
}
