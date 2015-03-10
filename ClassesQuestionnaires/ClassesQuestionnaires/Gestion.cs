using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;     //Librairie Oracle

namespace ClassesQuestionnaires
{
    public partial class Gestion : Form
    {
        OracleConnection connection;
        public Gestion(OracleConnection connectionx)
        {
            connection = connectionx;
            InitializeComponent();
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            ConnexionAdmin();
        }

        public void ConnexionAdmin()
        {
            AdminConnect dlgConect = new AdminConnect();
            dlgConect.ShowDialog();
            if (dlgConect.DialogResult == System.Windows.Forms.DialogResult.Cancel)
            {
                this.Close();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ModifierMotDePasse dlgNMP = new ModifierMotDePasse();
            dlgNMP.ShowDialog();
        }
    }
}
