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
    public partial class SelectCategorie : Form
    {
        public String Categorie;

        public SelectCategorie()
        {
            InitializeComponent();
        }
        private void SelectCategorie_Load(object sender, EventArgs e)
        {
            PNL_Histoire.BackColor = Properties.Settings.Default.CatColor_Histoire;
            PNL_Science.BackColor = Properties.Settings.Default.CatColor_Science;
            PNL_Geographie.BackColor = Properties.Settings.Default.CatColor_Geographie;
            PNL_Cinema.BackColor = Properties.Settings.Default.CatColor_Cinema;
        }

        private void Panel_MouseDown(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BorderStyle = BorderStyle.Fixed3D;
        }

        private void Panel_MouseEnter(object sender, EventArgs e)
        {
            ((Panel)sender).BorderStyle = BorderStyle.FixedSingle;
            this.Cursor = Cursors.Hand;
        }

        private void Panel_MouseLeave(object sender, EventArgs e)
        {
            ((Panel)sender).BorderStyle = BorderStyle.None;
            this.Cursor = Cursors.Arrow;
        }

        private void Panel_MouseUp(object sender, MouseEventArgs e)
        {
            ((Panel)sender).BorderStyle = BorderStyle.FixedSingle;
            String name = ((Panel)sender).Name;
            int index = name.IndexOf('_');
            Categorie = name.Substring(index + 1);
            ((Panel)sender).Refresh();
            System.Threading.Thread.Sleep(50);
            this.Close();
        }
    }
}
