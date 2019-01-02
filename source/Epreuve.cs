using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_n_1
{
    class Epreuve
    {
        private int distance;
        private string nom;
        private int tempsEliminatoire;

        public Epreuve(string nom, int distance)
        {
            this.nom = nom;
            this.distance = distance;
        }
        public int GetDistance
        {
            get
            {
                return distance;
            }
        }
        public string GetNom()
        {
            return this.nom;
        }
        public double GetTempsEliminatoire
        {
            get
            {
                return tempsEliminatoire;
            }
        }
        public void SetTempsEliminatoire(int tempsEliminatoire)
        {
            this.tempsEliminatoire = tempsEliminatoire;
        }

     
         }
}
