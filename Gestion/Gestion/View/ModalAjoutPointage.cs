
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/// <summary>
using System.Globalization;
using Gestion.Control;
using Npgsql;
using Gestion.Route;
/// </summary>

namespace Gestion.View
{
    public partial class ModalAjoutPointage : Form
    {
        /***************variable public******************/
        public static string valeurCheckBox = string.Empty;
        public static string selectedValue;
        public static DateTime date;
        public static string variable;
        public static string ID;
        //pour actualiser le table
        public UserControl acti;


        public ModalAjoutPointage(UserControl display)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ControlEmployes control = new ControlEmployes();
            RemplirComboBox(control);
            
            this.acti = display;
            textDateTime.Visible = false;
        }
        ControlPointages control = new ControlPointages();

        /***************bouton annuler******************/
        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            (acti as UserPointage).noClick();
        }

        /***************checkYes******************/
        private void YesCheck_Click(object sender, EventArgs e)
        {
            if (YesCheck.Checked)
            {
                YesCheck.Checked = true;
                NoCheck.Checked = false;// Désactiver la sélection du deuxième CheckBox
                valeurCheckBox = "Oui"; // La valeur de la case à cocher est "oui"
            }
            else
            {
                valeurCheckBox = string.Empty; // Réinitialiser la valeur si la case à cocher est décochée
            }
        }


        /***************checkNo******************/
        private void NoCheck_Click(object sender, EventArgs e)
        {
            if (NoCheck.Checked)
            {
                NoCheck.Checked = true;
                YesCheck.Checked = false; // Désactiver la sélection du premier CheckBox
                valeurCheckBox = "Non"; // La valeur de la case à cocher est "non"
            }
            else
            {
                valeurCheckBox = string.Empty; // Réinitialiser la valeur si la case à cocher est décochée
            }
        }

        /***************Remplir******************/
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
                    testeComboBox2.Items.Add(numEmp);
                }

                // On ajoute un événement pour récupérer la sélection de la ComboBox
                testeComboBox2.SelectedIndexChanged += (sender, e) => {
                    selectedValue = testeComboBox2.SelectedItem.ToString();
                };
            }
            else
            {
                // Une erreur s'est produite lors de la tentative de récupération des numéros d'employés
                MessageBox.Show("echec", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /******insert button******/
        private void AjoouterBtn_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dateTime.Value.Date; // Récupérer la date sélectionnée par l'utilisateur sans l'heure
            DateTime currentDateTime = DateTime.Now; // Récupérer la date et l'heure actuelles

            DateTime combinedDateTime = selectedDate.Date.Add(currentDateTime.TimeOfDay); // Combinaison de la date sélectionnée et de l'heure actuelle
            textDateTime.Text = combinedDateTime.ToString("yyyy-MM-dd HH:mm:ss");


            control.pointage = valeurCheckBox;
            control.numEmp_ref = selectedValue;

            date = control.datePointage = combinedDateTime;

            variable = combinedDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            // Insertion des données dans la base de données en utilisant la méthode d'insertion

            bool success = control.InsertPointage(control);
            if(success == true)
            {
                MessageBox.Show("Ajout avec success");
                this.Close();
                (acti as UserPointage).afficheOfTable();
                (acti as UserPointage).noClick();
            }
            else
            {
                MessageBox.Show("Ajout echec");
            }
        }
    }
}
