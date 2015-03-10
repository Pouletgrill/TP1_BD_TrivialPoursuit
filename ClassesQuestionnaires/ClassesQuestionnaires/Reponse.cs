using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesQuestionnaires
{
    public class Reponse
    {
        public String IdReponse { get; set; }
        public String Texte { get; set; }
        public bool EstBonne { get; set; }

        public Reponse(String id, String texte, bool estBonne)
        {
            this.IdReponse = id;
            this.Texte = texte;
            this.EstBonne = estBonne;
        }
    }
}
