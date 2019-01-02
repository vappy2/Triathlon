using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_n_1
{
    class Resultat
    {
        private int tempsRealise;
        Epreuve uneEpreuve;
        Participant unParticipant;

        public Resultat(Participant unParticipant, Epreuve uneEpreuve, int tempsRealise)
        {
            this.tempsRealise = tempsRealise;
            this.uneEpreuve = uneEpreuve;
            this.unParticipant = unParticipant;
        }
        public Epreuve GetEpreuve()
        {
            return this.uneEpreuve;
        }
        public int GetTempsRealise()
        {
            return this.tempsRealise;
        }
    }
}
