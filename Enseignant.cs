using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_étudiants
{
    public class Enseignant : Personne
    {
        public string MatiereEnseignee { get; set; }
        public int Matricule { get; set; }
        public Enseignant(string nom, string prenom, string matiereEnseignee, int matricule) : base(nom, prenom)
        {
                MatiereEnseignee = matiereEnseignee;
                Matricule = matricule;

        }
    }
}
