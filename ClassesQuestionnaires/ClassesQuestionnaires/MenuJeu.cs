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
      public MenuJeu()
      {
         InitializeComponent();
      }

      private void gestionToolStripMenuItem_Click(object sender, EventArgs e)
      {
         Gestion dlg = new Gestion(connection);
         dlg.ShowDialog();
      }
   }
}
