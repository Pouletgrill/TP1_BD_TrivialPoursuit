using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesQuestionnaires
{
    public class Question
    {
        public String IdQuestion { get; set; }
        public String Texte { get; set; }
        public String Categorie { get; set; }
        public List<Reponse> Reponses { get; set; }

        public Question(String id, String texte, String categorie, List<Reponse> reponses)
        {
            this.IdQuestion = id;
            this.Texte = texte;
            this.Categorie = categorie;
            this.Reponses = reponses;
        }

        public bool ValiderReponse(int index)
        {
            return Reponses.ElementAt(index).EstBonne;
        }
    }
}
