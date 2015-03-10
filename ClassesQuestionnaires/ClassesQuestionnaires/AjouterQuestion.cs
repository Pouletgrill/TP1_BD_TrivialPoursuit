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
    public partial class AjouterQuestion : Form
    {
        private bool bouttonvalide = false;
        private static String orcluserFR = "riouxfra";
        private static String orcluserXB = "brosseau";
        public String connectionString = "Data Source=(DESCRIPTION="    // ========== TO MOVE =========
                               + "(ADDRESS_LIST=(ADDRESS=(PROTOCOL=TCP)"
                               + "(HOST=205.237.244.251)(PORT=1521)))"
                               + "(CONNECT_DATA=(SERVICE_NAME=ORCL.clg.qc.ca)));"
                               + "User Id=" + orcluserFR + ";Password=ORACLE1";

        public OracleConnection connection;     // ========== TO MOVE =========

        public AjouterQuestion()
        {
            InitializeComponent();
        }

        private void AjouterQuestion_Load(object sender, EventArgs e)
        {
            Connecter(); // ========== TO DELETE =========
            ConstruireListeCategories();
            UpdateControls();
        }

        private void Connecter() // ========== TO MOVE =========
        {
            connection = new OracleConnection(connectionString);
            connection.ConnectionString = connectionString;

            try
            {
                connection.Open();
                MessageBox.Show(connection.State.ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur de connection");
            }
        }

        private void ConstruireListeCategories()
        {
            OracleCommand inserer = new OracleCommand("INSERTION", connection);
            inserer.CommandText = "PKG_QUESTIONS.LISTER_CATEGORIES";
            inserer.CommandType = CommandType.StoredProcedure;

            OracleParameter pResultat = new OracleParameter("PRESULTAT", OracleDbType.RefCursor);
            pResultat.Direction = ParameterDirection.ReturnValue;
            inserer.Parameters.Add(pResultat);

            OracleDataReader reader = inserer.ExecuteReader();

            while (reader.Read())
            {
                CMB_Categories.Items.Add(reader.GetString(0));
            }
        }

        private void UpdateControls()
        {
            BTN_Ajouter.Enabled = ( TB_Question.Text != "" &&
                                    TB_Reponse1.Text != "" &&
                                    TB_Reponse2.Text != "" &&
                                    TB_Reponse3.Text != "" &&
                                    TB_Reponse4.Text != "" &&
                                    CMB_Categories.SelectedItem != null);
        }

        private void TB_Question_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void CMB_Categories_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_Reponse1_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_Reponse2_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_Reponse3_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void TB_Reponse4_TextChanged(object sender, EventArgs e)
        {
            UpdateControls();
        }

        private void BTN_Annuler_Click(object sender, EventArgs e)
        {
           this.Close();
        }
    }
}
