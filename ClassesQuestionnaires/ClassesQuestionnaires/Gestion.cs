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
        DataSet dataSet = new DataSet();
        OracleConnection connection;
        public Gestion(OracleConnection connectionx)
        {
            connection = connectionx;
            InitializeComponent();
        }

        private void Gestion_Load(object sender, EventArgs e)
        {
            ConnexionAdmin();
            RefreshDGVQuestion();
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

        public void RefreshDGVQuestion()
        {
            try
            {
                // //déclaration de OracleCommand pour appeler la fonction avec la
                //connection conn.
                OracleCommand Oracmd = new OracleCommand("PKG_GESTION",
                connection);
                Oracmd.CommandText = "PKG_GESTION.AFFICHERQUESTION";
                Oracmd.CommandType = CommandType.StoredProcedure;
                // pour une fonction, le paramètre de retour doit être déclaré en
                //premier.
                OracleParameter OrapameResultat = new
                OracleParameter("CURSORGESTION", OracleDbType.RefCursor);
                OrapameResultat.Direction = ParameterDirection.ReturnValue;
                Oracmd.Parameters.Add(OrapameResultat);

                // Pour remplir le DataSet, on déclare un OracleDataAdapter pour lequel
                // on passe notre OracleCommand qui contient TOUS les paramètres.

                OracleDataAdapter orAdater = new OracleDataAdapter(Oracmd);
                if (dataSet.Tables.Contains("Question"))
                {
                    dataSet.Tables["Question"].Clear();
                }
                orAdater.Fill(dataSet, "Question");
                Oracmd.Dispose();
                BindingSource bindingSource;
                bindingSource = new BindingSource(dataSet, "Question");
                DGV_Question.DataSource = bindingSource;
                DGV_Question.Columns[2].Visible = false;
            }
            catch (Exception se)
            {
                MessageBox.Show(se.Message.ToString());
            }
        }

        private void SupprimerParID(String ID)
        {
            DialogResult confirme = MessageBox.Show("Voulez-vous Vraiment supprimer la question ?",
            "Confirmation",
            MessageBoxButtons.YesNo,
            MessageBoxIcon.Question,
            MessageBoxDefaultButton.Button2);
            if (confirme == DialogResult.Yes)
            {
                try
                {
                    OracleCommand Oracmd = new OracleCommand("PKG_GESTION",
                    connection);
                    Oracmd.CommandText = "PKG_GESTION.SUPPRIMERQUESTION";
                    Oracmd.CommandType = CommandType.StoredProcedure;

                    //Déclaration des paramettres
                    OracleParameter oraQuestionID = new OracleParameter("QUESTIONID", OracleDbType.Int32);
                    oraQuestionID.Direction = ParameterDirection.Input;
                    oraQuestionID.Value = ID.ToString();
                    Oracmd.Parameters.Add(oraQuestionID);

                    Oracmd.ExecuteNonQuery();
                    //MessageBox.Show("suppression réussie!");
                }
                catch (Exception se)
                {
                    MessageBox.Show(se.Message.ToString());
                }
            }
        }


        private void BTN_NMotPasse_Click(object sender, EventArgs e)
        {
            ModifierMotDePasse dlgNMP = new ModifierMotDePasse();
            dlgNMP.ShowDialog();
        }

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            AjouterQuestion dlgAjoutQuestion = new AjouterQuestion(connection);
            dlgAjoutQuestion.ShowDialog();
            RefreshDGVQuestion();
        }

        private void BTN_Modifier_Click(object sender, EventArgs e)
        {
            RefreshDGVQuestion();
        }

        private void BTN_Supprimer_Click(object sender, EventArgs e)
        {
            //http://www.codeproject.com/Questions/338684/get-value-from-selected-rows-in-datagridview
            SupprimerParID(DGV_Question.Rows[DGV_Question.CurrentRow.Index].Cells[2].Value.ToString());
            RefreshDGVQuestion();
        }
    }
}
