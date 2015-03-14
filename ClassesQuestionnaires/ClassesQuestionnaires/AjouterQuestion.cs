﻿using System;
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
        String fonction;
       OracleConnection connection;
        public AjouterQuestion(OracleConnection Connection)
        {
           connection = Connection;
            InitializeComponent();
            fonction = "AJOUT";
        }

        public AjouterQuestion(OracleConnection Connection,String ID)
        {
            connection = Connection;
            InitializeComponent();
            fonction = "MODIF";
            BTN_Ajouter.Text = "Modifier";
            MessageBox.Show(fonction + " " + ID);
        }

        private void AjouterQuestion_Load(object sender, EventArgs e)
        {
            ConstruireListeCategories();
            UpdateControls();
        }


        private void ConstruireListeCategories()
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

        private void BTN_Ajouter_Click(object sender, EventArgs e)
        {
            try
            {
                String BRep, MRep1, MRep2, MRep3;
                if (RB_Reponse1.Checked)
                {
                    BRep = TB_Reponse1.Text;
                    MRep1 = TB_Reponse2.Text;
                    MRep2 = TB_Reponse3.Text;
                    MRep3 = TB_Reponse4.Text;
                }
                else if (RB_Reponse2.Checked)
                {
                    BRep = TB_Reponse2.Text;
                    MRep1 = TB_Reponse1.Text;
                    MRep2 = TB_Reponse3.Text;
                    MRep3 = TB_Reponse4.Text;
                }
                else if (RB_Reponse3.Checked)
                {
                    BRep = TB_Reponse3.Text;
                    MRep1 = TB_Reponse1.Text;
                    MRep2 = TB_Reponse2.Text;
                    MRep3 = TB_Reponse4.Text;
                }
                else
                {
                    BRep = TB_Reponse4.Text;
                    MRep1 = TB_Reponse1.Text;
                    MRep2 = TB_Reponse2.Text;
                    MRep3 = TB_Reponse3.Text;
                }

                OracleCommand oraAjout = new OracleCommand("PKG_GESTION", connection);
                oraAjout.CommandText = "PKG_GESTION.INSERTIONQUESTION";
                oraAjout.CommandType = CommandType.StoredProcedure;

                //Déclaration des paramettres
                OracleParameter procQuestion = new OracleParameter("PQUESTION", OracleDbType.Varchar2,250);
                procQuestion.Direction = ParameterDirection.Input;
                procQuestion.Value = TB_Question.Text;
                oraAjout.Parameters.Add(procQuestion);

                OracleParameter procCategorie = new OracleParameter("PCATEGORIE", OracleDbType.Varchar2, 10);
                procCategorie.Direction = ParameterDirection.Input;
                procCategorie.Value = CMB_Categories.SelectedItem.ToString()[0].ToString();//retourne le premier caractère du string
                oraAjout.Parameters.Add(procCategorie);

                OracleParameter procBRep = new OracleParameter("REPONSE_BONNE", OracleDbType.Varchar2, 250);
                procBRep.Direction = ParameterDirection.Input;
                procBRep.Value = BRep;
                oraAjout.Parameters.Add(procBRep);

                OracleParameter procMRep1 = new OracleParameter("REPONSE_MAUVAISE_1", OracleDbType.Varchar2, 250);
                procMRep1.Direction = ParameterDirection.Input;
                procMRep1.Value = MRep1;
                oraAjout.Parameters.Add(procMRep1);

                OracleParameter procMRep2 = new OracleParameter("REPONSE_MAUVAISE_2", OracleDbType.Varchar2, 250);
                procMRep2.Direction = ParameterDirection.Input;
                procMRep2.Value = MRep2;
                oraAjout.Parameters.Add(procMRep2);

                OracleParameter procMRep3 = new OracleParameter("REPONSE_MAUVAISE_3", OracleDbType.Varchar2, 250);
                procMRep3.Direction = ParameterDirection.Input;
                procMRep3.Value = MRep3;
                oraAjout.Parameters.Add(procMRep3);

                //Execution de la requête
                oraAjout.ExecuteNonQuery();
                //MessageBox.Show("Insertion réusit");
            }
            catch (OracleException Oe)
            {
                MessageBox.Show(Oe.Message);
            }
        }
    }
}
