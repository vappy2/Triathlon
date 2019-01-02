using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_n_1
{
    class Participant
    {
        private DateTime dateInscription;
        private int id;
        private string nom;
        List<Resultat> lesResultats;

        public Participant(string nom, DateTime dateInscription)
        {
            this.nom = nom;
            this.dateInscription = dateInscription;
        }

        public void Add(Epreuve uneEpreuve, int tempsRealise)
        {
            if (resultatPresent(uneEpreuve) == false)
            {
                Resultat unResultat = new Resultat(this, uneEpreuve, tempsRealise);
                this.lesResultats.Add(unResultat);
            }
        }

        public DateTime GetDateInscription()
        {
            return this.dateInscription;
        }
        public int GetId()
        {
            return this.id;
        }
        public string GetNom()
        {
            return this.nom;
        }
        public int GetTempsTotal()
        {
            int TempsTot;
            TempsTot = 0;
            return TempsTot;     
        }

        public bool HorsDelai() {
            int success = 0;
            for (int i = 0; i < lesResultats.Count; i++)
            {
                if (lesResultats[i].GetEpreuve().GetNom() != "course")
                {
                    if (lesResultats[i].GetTempsRealise() < lesResultats[i].GetEpreuve().GetTempsEliminatoire)
                    {
                        success += 1;
                    }
                }
            }
            if (success == 2)
            {
                return false; 
            }
            else
            {
                return true;
            }
            
        }

        public bool resultatPresent(Epreuve uneEpreuve) {
            for (int i = 0; i < lesResultats.Count(); i++) {
                if (lesResultats[i].GetEpreuve().GetNom() == uneEpreuve.GetNom())
                {
                    return true;
                }
            }
         return false;
            
        }
    }
}
