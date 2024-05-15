using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_étudiants
{
    [Serializable]
    public class Cours
    {
        public string NomCours { get; set; }
        public string ProfesseurResponsable { get; set; }
        public Cours(string nomCours, string profResponsable)
        {
            NomCours = nomCours;
            ProfesseurResponsable = profResponsable;
        }
    }
}
