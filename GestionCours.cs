using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gestionnaire_étudiants
{
    public class GestionCours
    {
        public static List<Cours> listeCours = new List<Cours>();

        public static void AjouterCours(string nomCours, string professeurResponsable)
        {
            var nouveauCours = new Cours ( nomCours, professeurResponsable );
            listeCours.Add(nouveauCours);
        }
    }
}
