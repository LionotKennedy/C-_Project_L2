using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/****include****/
using Gestion.Control;
using Gestion.Route;

namespace Gestion.View
{
    public partial class ModalEmployes : Form
    {
        /*****************variable public**********************/
        public static string numero;
        public static string nom;
        public static string prenom;
        public static string poste;
        public static int salaire;
        public UserControl uc;

        /************************tsy hsiko*****************************/
        public ModalEmployes(UserControl display)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.uc = display;
        }
        ControlEmployes control = new ControlEmployes();

        /*********************bouton annuler******************************/
        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            (uc as UserEmployes).NoClick();
        }

        /****************************bouton ajouter******************************/
        private void AjoouterBtn_Click(object sender, EventArgs e)
        {
            // get value from input //
            numero = control.numEmp = textNumero.Text;
            nom = control.nomEmp = textNom.Text;
            prenom = control.prenomEmp = textPrenom.Text;
            poste = control.post = textPoste.Text;

            // Vérifier si les champs requis sont vides
            if (string.IsNullOrWhiteSpace(numero))
            {
                MessageBox.Show("Erreur : Veuillez saisir un numéro d'employé");
                return;
            }
            if (string.IsNullOrWhiteSpace(nom))
            {
                MessageBox.Show("Erreur : Veuillez saisir un nom");
                return;
            }
            if (string.IsNullOrWhiteSpace(prenom))
            {
                MessageBox.Show("Erreur : Veuillez saisir un prénom");
                return;
            }
            if (string.IsNullOrWhiteSpace(poste))
            {
                MessageBox.Show("Erreur : Veuillez saisir un poste");
                return;
            }
            if (string.IsNullOrWhiteSpace(textSalaire.Text))
            {
                MessageBox.Show("Erreur : Veuillez saisir un salaire");
                return;
            }


            // Vérifier si le salaire peut être converti en entier
            if (int.TryParse(textSalaire.Text, out int salaire))
            {
                control.salaire = salaire;

                // Insérer les données dans la base de données en utilisant la méthode Insert
                bool success = control.Insert(control);
                if (success)
                {
                    MessageBox.Show("Ajout réussi !");
                    this.Close();
                    (uc as UserEmployes).affichage();
                    (uc as UserEmployes).NoClick();
                }
                else
                {
                    MessageBox.Show("Échec de l'ajout");
                }
            }
            else
            {
                MessageBox.Show("Erreur : le salaire doit être un nombre entier");
            }
        }
    }
}
