
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/******* include code *********/
using Gestion.Route;
using Gestion.Control;
using Npgsql;

namespace Gestion.View
{
    public partial class ModalPointageUpdate : Form
    {
        /************variable public************/
        public static string valeurCheckBox = string.Empty;
        public static string selectedValue;
        public static DateTime date;
        public static string variable;

        public UserControl acti;
        public ModalPointageUpdate(UserControl display)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            ControlEmployes control = new ControlEmployes();
            
            UpdateControls();
            CheckBoxControl();
            ComboBoxContrel();
            DateTimeControl();
            comboboxUpdate(control);

            this.acti = display;

            UpdateCheckBox.Visible = false;
            pointageText.Visible = false;
            updateNumero.Visible = false;
            textDateTime.Visible = false;
        }
        ControlPointages control = new ControlPointages();

        /************recuperation ************/
        public void UpdateControls()
        {
            updateNumero.Text = UserPointage.A;                        
            UpdateCheckBox.Text = ModalAjoutPointage.valeurCheckBox;                                            
            textDateTime.Text = ModalAjoutPointage.variable;         
        }
        /************recuperation date************/
        public void DateTimeControl()
        {
            updateDateTime.Text = ModalAjoutPointage.variable;
        }

        /************recuperation value combobox************/
        public void ComboBoxContrel()
        {
            updateComboBox.SelectedItem = ModalAjoutPointage.valeurCheckBox;

            string valeurComboBox = ModalAjoutPointage.valeurCheckBox;

            if (!updateComboBox.Items.Contains(valeurComboBox))
            {
                // Si la valeur n'est pas présente dans la liste, on l'ajoute d'abord
                updateComboBox.Items.Add(valeurComboBox);
            }
            // Ensuite, on la sélectionne
            updateComboBox.SelectedItem = valeurComboBox;

        }

        /************recuperation value check box************/
        public void CheckBoxControl()
        {
            pointageText.Text = ModalAjoutPointage.selectedValue;

            if (pointageText.Text == "Oui")
            {
                YesCheck.Checked = true;
                NoCheck.Checked = false;// Désactiver la sélection du deuxième CheckBox
                valeurCheckBox = "Oui"; // La valeur de la case à cocher est "oui"
            }
            else if (pointageText.Text == "Non")
            {
                YesCheck.Checked = false;
                NoCheck.Checked = true;// Désactiver la sélection du deuxième CheckBox
                valeurCheckBox = "Non"; // La valeur de la case à cocher est "oui"
            }
        }

        /************recuperation checkNo************/
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


        /************recuperation checkYes************/
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


        /************recuperation combobox************/
        public void comboboxUpdate(ControlEmployes control)
        {
            /******************************start********************************/
            updateComboBox.SelectedItem = ModalAjoutPointage.valeurCheckBox;

            string valeurComboBox = ModalAjoutPointage.valeurCheckBox;

            if (!updateComboBox.Items.Contains(valeurComboBox))
            {
                // Si la valeur n'est pas présente dans la liste, on l'ajoute d'abord
                updateComboBox.Items.Add(valeurComboBox);
            }
            // Ensuite, on la sélectionne
            updateComboBox.SelectedItem = valeurComboBox;
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
                string valeurSelectionnee = ModalAjoutPointage.valeurCheckBox;

                reader.Close(); // On ferme le lecteur après avoir récupéré toutes les données

                foreach (string numEmp in numEmps)
                {
                    if (numEmp != valeurSelectionnee)
                    {
                        updateComboBox.Items.Add(numEmp);
                    }
                }
                // On récupère la valeur sélectionnée automatiquement
                selectedValue = updateComboBox.SelectedItem.ToString();
                // On ajoute un événement pour récupérer la sélection de la ComboBox
                updateComboBox.SelectedIndexChanged += (sender, e) => {
                    selectedValue = updateComboBox.SelectedItem.ToString();
                };
                // Sélection par défaut du premier élément de la liste
                updateComboBox.SelectedIndex = 0;
            }
            else
            {
                // Une erreur s'est produite lors de la tentative de récupération des numéros d'employés
                MessageBox.Show("echec", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /************annuler************/
        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            (acti as UserPointage).noClick();
        }


        /************bouton modifier************/
        private void ModifierBtn_Click(object sender, EventArgs e)
        {
   
            DateTime selectedDate = updateDateTime.Value.Date; // Récupérer la date sélectionnée par l'utilisateur sans l'heure
            DateTime currentDateTime = DateTime.Now;
            DateTime combinedDateTime = selectedDate.Date.Add(currentDateTime.TimeOfDay); // Combinaison de la date sélectionnée et de l'heure actuelle
            updateDateTime.Text = combinedDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            control.IdPointage = int.Parse(updateNumero.Text);
            control.numEmp_ref = selectedValue;
            control.pointage = valeurCheckBox;
            date = control.datePointage = combinedDateTime;
            variable = combinedDateTime.ToString("yyyy-MM-dd HH:mm:ss");

            bool success = control.UpdatePointage(control);
            if (success == true)
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
