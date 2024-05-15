using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using Newtonsoft.Json;
namespace Gestionnaire_étudiants
{
    class GestionEnseignants
    {
        public static List<Enseignant> listeEnseignant = new List<Enseignant>();

        public static void AjouterEnseignant(int Matricule, string nom, string prenom, string matiere)
        {
            Enseignant nouvelEtudiant = new Enseignant(nom, prenom, matiere, Matricule);
            listeEnseignant.Add(nouvelEtudiant);
        }

        public static void SupprimerEnseignant(int matricule)
        {
            Enseignant enseignantASupprimer = listeEnseignant.Find(e => e.Matricule == matricule);
            if (enseignantASupprimer != null)
            {
                listeEnseignant.Remove(enseignantASupprimer);
                Console.WriteLine($"enseignant {enseignantASupprimer.Nom} {enseignantASupprimer.Prenom} supprimé.");
            }
            else
            {
                Console.WriteLine("enseignant non trouvé.");
            }
        }

        public static void AfficherListeEtudiants()
        {
            foreach (Enseignant enseignant in listeEnseignant)
            {
                Console.WriteLine($"Matricule: {enseignant.Matricule} Nom : {enseignant.Nom}, Prénom : {enseignant.Prenom}, Matière : {enseignant.MatiereEnseignee}");
            }
        }

    }
}

