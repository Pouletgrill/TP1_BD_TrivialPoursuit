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
    public partial class ModifierMotDePasse : Form
    {
        public ModifierMotDePasse()
        {
            InitializeComponent();
        }

        private void BTN_Ok_Click(object sender, EventArgs e)
        {
            if (TB_Password.Text == Properties.Settings.Default.PasswordAdmin)
            {
                if (TB_NouveauMP.Text == TB_NMPValidation.Text)//validation nouveau mot de passe
                {
                    Properties.Settings.Default.PasswordAdmin = TB_NouveauMP.Text;
                    Properties.Settings.Default.Save();//Changement de mot de passe
                    MessageBox.Show("Mot de passe changé",
                    "Gestion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Asterisk,
                    MessageBoxDefaultButton.Button1);
                    this.Close();
                }
                else
                {
                    MessageBox.Show("le nouveau mot de passe n'est pas validé correctement",
                    "Gestion",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Hand,
                    MessageBoxDefaultButton.Button1);
                    TB_NouveauMP.Text = "";
                    TB_NMPValidation.Text = "";
                }
            }
            else
            {
                MessageBox.Show("Mot de passe invalide",
                "Gestion",
                MessageBoxButtons.OK,
                MessageBoxIcon.Hand,
                MessageBoxDefaultButton.Button1);
                TB_Password.Text = "";
            }
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
