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
   }
}
