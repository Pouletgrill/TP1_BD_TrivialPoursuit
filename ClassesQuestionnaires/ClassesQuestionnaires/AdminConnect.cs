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
   public partial class AdminConnect : Form
   {

      public AdminConnect()
      {
         InitializeComponent();
      }

      private void BTN_Ok_Click(object sender, EventArgs e)
      {
         if (TB_Password.Text == Properties.Settings.Default.PasswordAdmin)
         {
            this.Close();
         }
         else
         {
            MessageBox.Show("Mot de passe invalide",
               "Gestion",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information,
               MessageBoxDefaultButton.Button1);
         }
      }
   }
}
