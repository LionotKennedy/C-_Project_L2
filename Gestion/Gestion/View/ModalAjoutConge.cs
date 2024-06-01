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
using Npgsql;

namespace Gestion.View
{
    public partial class ModalAjoutConge : Form
    {
        /************variable public*************/
        public static string selectedValue;
        public static string numero;
        public static string motif;
        public static DateTime date1,date2;
        public static string variable1,variable2;
        public static int nombrjr;
        public UserControl Affi;


        public ModalAjoutConge(UserControl display)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ControlEmployes control = new ControlEmployes();
            RemplirComboBox(control);
            this.Affi = display;

            textDemande.Visible = false;
            textRetour.Visible = false;
        }
        ControlConge control = new ControlConge();


        /************remplirComboBox*************/
        public void RemplirComboBox(ControlEmployes control)
        {
            NpgsqlDataReader reader = control.ComboBox();

            if (reader != null)
            {
                // On ajoute les numéros d'employés à une liste temporaire
                List<string> numEmps = new List<string>();

                while (reader.Read())
                {
                    string numEmp = reader.GetString(0);
                    numEmps.Add(numEmp);
                }

                reader.Close(); // On ferme le lecteur après avoir récupéré toutes les données

                // On ajoute les numéros d'employés à la ComboBox
                foreach (string numEmp in numEmps)
                {
                    comboboxEmp.Items.Add(numEmp);
                }

                // On ajoute un événement pour récupérer la sélection de la ComboBox
                comboboxEmp.SelectedIndexChanged += (sender, e) => {
                    selectedValue = comboboxEmp.SelectedItem.ToString();
                    //MessageBox.Show("La valeur sélectionnée est : " + selectedValue, "Sélection", MessageBoxButtons.OK, MessageBoxIcon.Information);
                };
            }
            else
            {
                // Une erreur s'est produite lors de la tentative de récupération des numéros d'employés
                MessageBox.Show("echec", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /************annuler*************/
        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            (Affi as UserConge).NoClick();
        }       
        /************Ajouterx*************/
        private void AjoouterBtn_Click(object sender, EventArgs e)
        {
            // Récupérer la date de demande
            DateTime selectedDateDemande = dateDemande.Value.Date;
            DateTime currentDateTimeDemande = DateTime.Now;
            DateTime combinedDateTimeDemande = selectedDateDemande.Date.Add(currentDateTimeDemande.TimeOfDay);
            textDemande.Text = combinedDateTimeDemande.ToString("yyyy-MM-dd");

            // Récupérer la date de retour
            DateTime selectedDateRetour = dateRetour.Value.Date;
            DateTime currentDateTimeRetour = DateTime.Now;
            DateTime combinedDateTimeRetour = selectedDateRetour.Date.Add(currentDateTimeRetour.TimeOfDay);
            textRetour.Text = combinedDateTimeRetour.ToString("yyyy-MM-dd");

            // Vérifier si les champs requis sont vides
            if (string.IsNullOrWhiteSpace(textNumero.Text))
            {
                MessageBox.Show("Erreur : Veuillez saisir un numéro");
                return;
            }
            if (string.IsNullOrWhiteSpace(textMotif.Text))
            {
                MessageBox.Show("Erreur : Veuillez saisir un motif");
                return;
            }
            if (string.IsNullOrWhiteSpace(textNombreJours.Text))
            {
                MessageBox.Show("Erreur : Veuillez saisir un nombre de jours");
                return;
            }

            // Vérifier si le nombre de jours peut être converti en entier
            if (int.TryParse(textNombreJours.Text, out int nombreJours))
            {
                // Vérifier si la valeur saisie existe déjà dans la base de données
                string numeroConge = textNumero.Text;
                if (control.CongeExists(numeroConge))
                {
                    MessageBox.Show("Ptrrr, ça va pas mon pote : le numéro de congé existe déjà !");
                    return;
                }

                // Récupérer les valeurs des champs de saisie
                control.numEmp_ref = selectedValue;
                numero = control.numConge = textNumero.Text;
                motif = control.motif = textMotif.Text;
                nombrjr = control.nombreJour = nombreJours;

                date1 = control.dateDemande = combinedDateTimeDemande;
                variable1 = combinedDateTimeDemande.ToString("yyyy-MM-dd");

                date2 = control.dateRetour = combinedDateTimeRetour;
                variable2 = combinedDateTimeRetour.ToString("yyyy-MM-dd");



                // Insérer les données dans la base de données en utilisant la méthode InsertConge
                bool success = control.InsertConge(control);
                if (success)
                {
                    MessageBox.Show("Ajout réussi !");
                    this.Close();
                    (Affi as UserConge).affichageConge();
                    (Affi as UserConge).NoClick();
                }
                else
                {
                    MessageBox.Show("Échec de l'ajout");
                }
            }
            else
            {
                MessageBox.Show("Erreur : le nombre de jours doit être un nombre entier");
            }
        }
    }
}
