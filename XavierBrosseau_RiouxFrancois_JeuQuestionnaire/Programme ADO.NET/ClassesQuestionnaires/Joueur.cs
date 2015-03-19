using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesQuestionnaires
{
    public class Joueur
    {
        public String Alias { get; set; }
        public int OrdreJeu { get; set; }

        public Joueur(String alias, int ordre)
        {
            this.Alias = alias;
            this.OrdreJeu = ordre;
        }

        public int Repondre(Panel choixDeReponses)
        {
            int index = -1;
            bool trouve = false;
            for (int i = 0; i < choixDeReponses.Controls.Count && !trouve; ++i)
            {
                RadioButton rb = (RadioButton)choixDeReponses.Controls[i];
                String str = rb.Text;
                trouve = rb.Checked;

                if (trouve)
                    index = i;
            }

            return index;
        }
    }
}
