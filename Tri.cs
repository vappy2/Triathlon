using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DS_n_1
{
    class Tri
    {
        private string nature;
        Epreuve natation;
        Epreuve velo;
        Epreuve course;
        List<Participant> lesParticipants;

        public Tri(string nature, int distanceNatation, int distanceVelo, int distanceCourse)
        {
            this.nature = nature;
            this.natation = new Epreuve("natation", distanceNatation);
            this.velo = new Epreuve("velo", distanceVelo);
            this.course = new Epreuve("course", distanceCourse);
        }
        public void AddParticipant(Participant unParticipant)
        {
            this.lesParticipants.Add(unParticipant);
        }
        public int GetDistanceTotale()
        {
            int DistanceTot;
            DistanceTot = this.natation.GetDistance + this.velo.GetDistance + this.course.GetDistance;
            return DistanceTot;
        }
        public Epreuve GetEpreuve(string nomEpreuve)
        {
            switch (nomEpreuve)
            {
                case "natation":
                    return this.natation;
                case "velo":
                    return this.velo;
                default:
                    return this.course;
            }
        }

        public List<Participant> GetLesTemps()
        {
            List<Participant> enCours = new List<Participant>();
            foreach (Participant P in lesParticipants)
            {
                if (P.HorsDelai() == false)
                {
                    enCours.Add(P);
                }
                
            }
            return enCours;
        }
        public string GetNature
        {
            get
            {
                return this.nature;
            }
        }

        public Participant GetParticipantById(int id)
        {
            foreach (Participant P in lesParticipants)
            {
                if (P.GetId() == id)
                {
                    return P;
                }                
            }
            return null;
        }
    }
}
