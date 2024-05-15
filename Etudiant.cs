using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Gestionnaire_étudiants
{
    [Serializable]
    public class Etudiant: Personne
    {
        public int NumeroEtudiant { get; set; }
        public  List<string> CoursInscrits { get; set; }

        public Etudiant(string nom, string prenom, int numeroEtudiant) : base(nom, prenom)
        {
            NumeroEtudiant = numeroEtudiant;
            CoursInscrits = new List<string>();
        } 
        
        //Pour la sauvegarde
        static List<Etudiant> etudiant = new List<Etudiant>();
        public static void SauvegardeXML(List<Etudiant> etudiant, string nomfichier)
        {
            try
            {
                using (FileStream f = File.Open(nomfichier, FileMode.OpenOrCreate))
                {
                    XmlSerializer s = new XmlSerializer(typeof(List<Etudiant>));
                    s.Serialize(f, etudiant);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite lors de la sauvegarde XML : " + ex.Message);
            }
        }
        //Pour le chargement
        public static List<Etudiant> ChargerXML(string nomfichier)
        {
            List<Etudiant> etudiants = new List<Etudiant>();
            try
            {
                if (File.Exists(nomfichier))
                {
                    using (FileStream f = File.Open(nomfichier, FileMode.Open))
                    {
                        XmlSerializer s = new XmlSerializer(typeof(List<Etudiant>));
                        etudiants = (List<Etudiant>)s.Deserialize(f);
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Une erreur s'est produite lors du chargement XML : " + ex.Message);
            }
            return etudiants;
        }
    }
}
