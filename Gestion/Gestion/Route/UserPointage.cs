
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//**** include ****//
using Gestion.Control;
using Gestion.View;

namespace Gestion.Route
{
    public partial class UserPointage : UserControl
    {
        //******variable public******//
        public static string A;
        public static string B;
        public UserPointage()
        {
            InitializeComponent();
            afficheOfTable();

            textId.Visible = false;
            textPointage.Visible = false;
            textNum.Visible = false;
            textDate.Visible = false;

            noClick();
        }
        //******relation controleur comme requete******//
        ControlPointages control = new ControlPointages();


        //******ajputer bouton******//
        private void btnAjouterPointage_Click(object sender, EventArgs e)
        {
            ModalAjoutPointage pointage = new ModalAjoutPointage(this);
            pointage.Show();
        }

        //******Modifier bouton******//
        private void BtnModifier_Click(object sender, EventArgs e)
        {
            ModalPointageUpdate pointage = new ModalPointageUpdate(this);
            pointage.Show();
        }

        //******affichage******//
        public void afficheOfTable()
        {
            DataTable dataTable = control.SelectPointage();
            dataTablePointage.DataSource = dataTable;
        }


        //******click table******//
        private void dataTablePointage_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            BtnDelete.Enabled = true;
            BtnModifier.Enabled = true;

            try
            {
                int rowIndex = e.RowIndex;
                ModalAjoutPointage.ID = dataTablePointage.Rows[rowIndex].Cells[0].Value.ToString();
                ModalAjoutPointage.valeurCheckBox = dataTablePointage.Rows[rowIndex].Cells[1].Value.ToString();
                ModalAjoutPointage.selectedValue = dataTablePointage.Rows[rowIndex].Cells[2].Value.ToString();
                ModalAjoutPointage.variable = dataTablePointage.Rows[rowIndex].Cells[3].Value.ToString();

                A = textId.Text = dataTablePointage.Rows[rowIndex].Cells[0].Value.ToString();
                textPointage.Text = dataTablePointage.Rows[rowIndex].Cells[1].Value.ToString();
                B = textNum.Text = dataTablePointage.Rows[rowIndex].Cells[2].Value.ToString();
                textDate.Text = dataTablePointage.Rows[rowIndex].Cells[3].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //******suppression bouton******//
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Récupérer l'ID du pointage à supprimer (ici, A représente cette valeur)
            control.IdPointage = int.Parse(A);

            // Afficher une boîte de dialogue de confirmation
            DialogResult result = MessageBox.Show("Es-tu sûr de vouloir supprimer ce pointage ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Vérifier la réponse de l'utilisateur
            if (result == DialogResult.Yes)
            {
                // Suppression si l'utilisateur a cliqué sur "Oui"
                bool success = control.Delete(control);
                if (success)
                {
                    MessageBox.Show("Suppression réussie !");
                }
                else
                {
                    MessageBox.Show("Échec de la suppression");
                }
            }
            else
            {
                // Affichage d'un message si l'utilisateur a cliqué sur "Non"
                MessageBox.Show("Suppression annulée !");
            }

            // Mettre à jour l'affichage
            afficheOfTable();
            noClick();
        }
        //******start******//
        public void noClick()
        {
            BtnDelete.Enabled = false;
            BtnModifier.Enabled = false;
        }
    }
}
