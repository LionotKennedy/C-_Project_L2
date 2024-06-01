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
    public partial class ModalUpdateConge : Form
    {
        /************variable public************/
        public static string selectedValue;
        public static string valeurCheckBox = string.Empty; 
        public static string numero;
        public static string motif;
        public static DateTime date1, date2;
        public static string variable1, variable2;
        public static int nombrjr;
        public UserControl Affi;


        public ModalUpdateConge(UserControl display)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ControlEmployes control = new ControlEmployes();

            UpdateControls();
            DateTimeControl();
            ComboBoxContrel();
            comboboxUpdate(control);

            this.Affi = display;

            textNumero.Visible = false;
            textDemande.Visible = false;
            textRetour.Visible = false;

        }
        ControlConge control = new ControlConge();

        /************recuperation texte************/
        public void UpdateControls()
        {
            textNumero.Text = ModalAjoutConge.numero;
            textMotif.Text = ModalAjoutConge.motif;
            textNombreJours.Text = ModalAjoutConge.nombrjr.ToString();

            textDemande.Text = ModalAjoutConge.variable1;
            textRetour.Text = ModalAjoutConge.variable2;
        }
        /************recuperation date************/
        public void DateTimeControl()
        {
            dateDemande.Text = ModalAjoutConge.variable1;
            dateRetour.Text = ModalAjoutConge.variable2;
        }
        /************recuperation combobox************/
        public void ComboBoxContrel()
        {
            comboboxEmp.SelectedItem = ModalAjoutConge.selectedValue;

            string valeurComboBox = ModalAjoutConge.selectedValue;

            if (!comboboxEmp.Items.Contains(valeurComboBox))
            {
                // Si la valeur n'est pas présente dans la liste, on l'ajoute d'abord
                comboboxEmp.Items.Add(valeurComboBox);
            }
            // Ensuite, on la sélectionne
            comboboxEmp.SelectedItem = valeurComboBox;

        }

        /************recuperation combobox************/
        public void comboboxUpdate(ControlEmployes control)
        {
            /******************************start********************************/
            comboboxEmp.SelectedItem = ModalAjoutConge.selectedValue;

            string valeurComboBox = ModalAjoutConge.selectedValue;

            if (!comboboxEmp.Items.Contains(valeurComboBox))
            {
                // Si la valeur n'est pas présente dans la liste, on l'ajoute d'abord
                comboboxEmp.Items.Add(valeurComboBox);
            }
            // Ensuite, on la sélectionne
            comboboxEmp.SelectedItem = valeurComboBox;
            /******************************ending**********************************/

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
                string valeurSelectionnee = ModalAjoutConge.selectedValue;

                reader.Close(); // On ferme le lecteur après avoir récupéré toutes les données

                foreach (string numEmp in numEmps)
                {
                    if (numEmp != valeurSelectionnee)
                    {
                        comboboxEmp.Items.Add(numEmp);
                    }
                }
                // On récupère la valeur sélectionnée automatiquement
                selectedValue = comboboxEmp.SelectedItem.ToString();
                // On ajoute un événement pour récupérer la sélection de la ComboBox
                comboboxEmp.SelectedIndexChanged += (sender, e) => {
                    selectedValue = comboboxEmp.SelectedItem.ToString();
                };

                // Sélection par défaut du premier élément de la liste
                comboboxEmp.SelectedIndex = 0;
            }
            else
            {
                // Une erreur s'est produite lors de la tentative de récupération des numéros d'employés
                MessageBox.Show("echec", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /************annuler bouton************/
        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            (Affi as UserConge).NoClick();
        }


        /************bouton modification************/
        private void AjoouterBtn_Click(object sender, EventArgs e)
        {
            /***************demandeDate*************/
            DateTime selectedDateDemande = dateDemande.Value.Date; // Récupérer la date sélectionnée par l'utilisateur sans l'heure
            DateTime currentDateTimeDemande = DateTime.Now; // Récupérer la date et l'heure actuelles
            DateTime combinedDateTimeDemande = selectedDateDemande.Date.Add(currentDateTimeDemande.TimeOfDay); // Combinaison de la date sélectionnée et de l'heure actuelle
            textDemande.Text = combinedDateTimeDemande.ToString("yyyy-MM-dd"); // Afficher la date et l'heure combinées



            /***************dateRetour*************/
            DateTime selectedDateRetour = dateRetour.Value.Date; // Récupérer la date sélectionnée par l'utilisateur sans l'heure
            DateTime currentDateTimeRetour = DateTime.Now; // Récupérer la date et l'heure actuelles
            DateTime combinedDateTimeRetour = selectedDateRetour.Date.Add(currentDateTimeRetour.TimeOfDay); // Combinaison de la date sélectionnée et de l'heure actuelle
            textRetour.Text = combinedDateTimeRetour.ToString("yyyy-MM-dd"); // Afficher la date et l'heure combinées


            // get value from input //
            control.numEmp_ref = selectedValue;
            numero = control.numConge = textNumero.Text;
            motif = control.motif = textMotif.Text;
            nombrjr = control.nombreJour = int.Parse(textNombreJours.Text);

            date1 = control.dateDemande = combinedDateTimeDemande;
            variable1 = combinedDateTimeDemande.ToString("yyyy-MM-dd");

            date2 = control.dateRetour = combinedDateTimeRetour;
            variable2 = combinedDateTimeRetour.ToString("yyyy-MM-dd");

            bool success = control.UpdateConge(control);
             if (success == true)
             {
                 MessageBox.Show("Modification avec success");
                 this.Close();
                 (Affi as UserConge).affichageConge();
                (Affi as UserConge).NoClick();
            }
             else
             {
                 MessageBox.Show("echec de la Modification");
             }
        }
    }
}
