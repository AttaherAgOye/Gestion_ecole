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
    public class GestionEtudiant
    {
        public static List<Etudiant> listeEtudiants = new List<Etudiant>();

        public static void AjouterEtudiant(string nom, string prenom, int numeroEtudiant)
        {
            Etudiant nouvelEtudiant = new Etudiant ( nom, prenom, numeroEtudiant );
            listeEtudiants.Add(nouvelEtudiant);
        }

        public static void SupprimerEtudiant(int numeroEtudiant)
        {
            Etudiant etudiantASupprimer = listeEtudiants.Find(e => e.NumeroEtudiant == numeroEtudiant);
            if (etudiantASupprimer != null)
            {
                listeEtudiants.Remove(etudiantASupprimer);
                Console.WriteLine($"Étudiant {etudiantASupprimer.Nom} {etudiantASupprimer.Prenom} supprimé.");
            }
            else
            {
                Console.WriteLine("Étudiant non trouvé.");
            }
        }

        public static void AfficherListeEtudiants()
        {
            foreach (Etudiant etudiant in listeEtudiants)
            {
                Console.WriteLine($"Nom : {etudiant.Nom}, Prénom : {etudiant.Prenom}, Numéro étudiant : {etudiant.NumeroEtudiant}");
            }
        }

        public static void InscrireEtudiantACours(int numeroEtudiant, string nomCours)
        {
            Etudiant etudiant = listeEtudiants.Find(e => e.NumeroEtudiant == numeroEtudiant);
            if (etudiant != null)
            {
                etudiant.CoursInscrits.Add(nomCours);
                Console.WriteLine($"Étudiant {etudiant.Nom} est inscrit au cours : {nomCours}");
            }
            else
            {
                Console.WriteLine("Étudiant non trouvé.");
            }
        }
        public static void AfficherDetailsEtudiant(int numeroEtudiant)
        {
            var etudiant = listeEtudiants.Find(e => e.NumeroEtudiant == numeroEtudiant);
            if (etudiant != null)
            {
                Console.WriteLine($"Détails de l'étudiant {etudiant.Nom} {etudiant.Prenom} (Numéro étudiant : {etudiant.NumeroEtudiant}):");
                Console.WriteLine("Cours inscrits :");
                foreach (var cours in etudiant.CoursInscrits)
                {
                    Console.WriteLine($"- {cours}");
                }
            }
            else
            {
                Console.WriteLine("Étudiant non trouvé.");
            }
        }

        //Pour la sauvegarde
        public void EnregistrerDonnees(string nomFichier)
        {
            
            try
            {
                nomFichier = "C:\\Users\\hp\\Documents\\Gestion_Des_Etudiants_Groupe3\\Gestionnaire_étudiants\\Gestionnaire_étudiants\\"+ nomFichier+".json";
                Console.WriteLine(nomFichier);

                //IFormatter formatter = new BinaryFormatter();
                //using (Stream stream = new FileStream(nomFichier, FileMode.Create, FileAccess.Write))
                //{
                  //  formatter.Serialize(stream, listeEtudiants);
                //}
                string json = JsonConvert.SerializeObject(listeEtudiants, Formatting.Indented);
                File.WriteAllText(nomFichier, json);
                //MessageBox.Show("données sauvegardée");
                Console.WriteLine("Données des étudiants enregistrées avec succès !");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors de l'enregistrement des données : {ex.Message}");
            }
        }
        //Pour le chargement
        public static void ChargerDonnees(string nomFichier)
        {
            try
            {
                IFormatter formatter = new BinaryFormatter();
                using (Stream stream = new FileStream(nomFichier, FileMode.Open, FileAccess.Read))
                {
                    listeEtudiants = (List<Etudiant>)formatter.Deserialize(stream);
                }
                Console.WriteLine("Données des étudiants chargées avec succès !");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Erreur lors du chargement des données : {ex.Message}");
            }
        }
    }
}
