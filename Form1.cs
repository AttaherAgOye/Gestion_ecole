using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gestionnaire_étudiants;

namespace Modern_Sliding_Sidebar___C_Sharp_Winform
{
    public partial class Form1 : Form
    {
        bool sideBar_Expand = true;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void gunaPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
        private void Close_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Timer_Sidebar_Menu_Tick(object sender, EventArgs e)
        {
            if (sideBar_Expand)
            {
                SideBar.Width -= 10;
                if (SideBar.Width == SideBar.MinimumSize.Width)
                {
                    sideBar_Expand = false;
                    Timer_Sidebar_Menu.Stop();
                }
            }
            else
                {
                    SideBar.Width += 10;
                    if (SideBar.Width == SideBar.MaximumSize.Width)
                    {
                        sideBar_Expand = true;
                        Timer_Sidebar_Menu.Stop();
                    }
                }
        }   
        
        

        private void Menu_Button_Click(object sender, EventArgs e)
        {
            Timer_Sidebar_Menu.Start();
        }

        private void gunaImageButton1_Click(object sender, EventArgs e)
        {

        }

        private void Link_Github_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            
        }

        private void Home_Button_Click(object sender, EventArgs e)
        {
            tabEtudiant.Visible = true;
            tabEnseignant.Visible = false;
            tabCours.Visible = false;
        }
        public void Vidertext()
        {
            txtNom.Text = "";
            txtPrenom.Text = "";
            txtNumero.Text = "";
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string nom = txtNom.Text;
            string prenom = txtPrenom.Text;
            int numero = int.Parse(txtNumero.Text);

            if (nom != "" && prenom != "")
            {
                GestionEtudiant.AjouterEtudiant(nom, prenom, numero);
                listeEtudiants.Items.Clear();
                foreach (var etudiant in GestionEtudiant.listeEtudiants)
                {
                    ListViewItem item = new ListViewItem(new[] { etudiant.Nom, etudiant.Prenom, etudiant.NumeroEtudiant.ToString() });
                    listeEtudiants.Items.Add(item);
                }
                Vidertext();
                MessageBox.Show("Ajout avec succès !");
            }
            else
            {
                MessageBox.Show("Veillez remplir les champs svp!");
            }
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            if (listeEtudiants.SelectedItems.Count > 0)
            {
                listeEtudiants.Items.Remove(listeEtudiants.SelectedItems[0]);
                MessageBox.Show("l'élément a été supprimé avec succès");

            }
            else
            {
                MessageBox.Show("Aucun élément sélectionné !");
            }
        }

        private void btnModiffier_Click(object sender, EventArgs e)
        {
            if (listeEtudiants.SelectedItems.Count > 0)
            {
                string nom = txtNom.Text;
                string prenom = txtPrenom.Text;
                int numero = int.Parse(txtNumero.Text);

                listeEtudiants.SelectedItems[0].SubItems[0].Text = nom;
                listeEtudiants.SelectedItems[0].SubItems[1].Text = prenom;
                listeEtudiants.SelectedItems[0].SubItems[2].Text = numero.ToString();




                MessageBox.Show("l'élément a été modifié avec succès");

            }
            else
            {
                MessageBox.Show("Aucun élément sélectionné !");
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            tabEtudiant.Visible = false;


        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            int matricule = int.Parse(txtMatriculeE.Text);
            string nom = txtNomE.Text;
            string prenom = txtPrenomE.Text;
            string matiere = txtMatiereE.Text;

            if (nom != "" && prenom != "" && matiere !="")
            {
                GestionEnseignants.AjouterEnseignant(matricule, nom, prenom, matiere);
                listeEnseignants.Items.Clear();
                foreach (var enseignant in GestionEnseignants.listeEnseignant)
                {
                    ListViewItem item = new ListViewItem(new[] { enseignant.Matricule.ToString(), enseignant.Nom, enseignant.Prenom, enseignant.MatiereEnseignee });
                    listeEnseignants.Items.Add(item);
                }
                Vidertext();
                MessageBox.Show("Ajout avec succès !");
            }
            else
            {
                MessageBox.Show("Veillez remplir les champs svp!");
            }
        }

        private void Orders_Button_Click(object sender, EventArgs e)
        {
            tabEtudiant.Visible = false;
            tabCours.Visible = false;
            tabEnseignant.Visible = true;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (listeEnseignants.SelectedItems.Count > 0)
            {
                int matricule = int.Parse(txtMatriculeE.Text);
                string nom = txtNomE.Text;
                string prenom = txtPrenomE.Text;
                string matiere = txtMatiereE.Text;

                listeEnseignants.SelectedItems[0].SubItems[0].Text = matricule.ToString();
                listeEnseignants.SelectedItems[0].SubItems[1].Text = nom;
                listeEnseignants.SelectedItems[0].SubItems[2].Text = prenom;
                listeEnseignants.SelectedItems[0].SubItems[3].Text = matiere;




                MessageBox.Show("l'élément a été modifié avec succès");

            }
            else
            {
                MessageBox.Show("Aucun élément sélectionné !");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listeEnseignants.SelectedItems.Count > 0)
            {
                listeEnseignants.Items.Remove(listeEnseignants.SelectedItems[0]);
                MessageBox.Show("l'élément a été supprimé avec succès");

            }
            else
            {
                MessageBox.Show("Aucun élément sélectionné !");
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            string nom = txtNomC.Text;
            string enseignant = txtEnseignant.Text;
            if (nom != "" && enseignant != "")
            {
                GestionCours.AjouterCours(nom, enseignant);
                listeCours.Items.Clear();
                foreach (var cour in GestionCours.listeCours)
                {
                    ListViewItem item = new ListViewItem(new[] { cour.NomCours, cour.ProfesseurResponsable });
                    listeCours.Items.Add(item);
                }
                Vidertext();
                MessageBox.Show("Ajout avec succès !");
            }
            else
            {
                MessageBox.Show("Veillez remplir les champs svp!");
            }
        }

        private void Customers_Button_Click(object sender, EventArgs e)
        {
            tabEtudiant.Visible = false;
            tabEnseignant.Visible = false;
            tabCours.Visible = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (listeCours.SelectedItems.Count > 0)
            {
                string nom = txtNomC.Text;
                string enseignant = txtEnseignant.Text;

                listeCours.SelectedItems[0].SubItems[0].Text = nom;
                listeCours.SelectedItems[0].SubItems[1].Text = enseignant;
                




                MessageBox.Show("l'élément a été modifié avec succès");

            }
            else
            {
                MessageBox.Show("Aucun élément sélectionné !");
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (listeCours.SelectedItems.Count > 0)
            {
                listeCours.Items.Remove(listeCours.SelectedItems[0]);
                MessageBox.Show("l'élément a été supprimé avec succès");

            }
            else
            {
                MessageBox.Show("Aucun élément sélectionné !");
            }
        }

        private void Help_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

        private void tabCours_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
