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
    public partial class UserConge : UserControl
    {
        public static string A;
        public static string B;
        public UserConge()
        {
            InitializeComponent();
            affichageConge();

            textId.Visible = false;
            textNum.Visible = false;
            textPointage.Visible = false;
            textDate.Visible = false;
            nombre.Visible = false;
            dateRetour.Visible = false;


            NoClick();
        }
        ControlConge control = new ControlConge();
        /***************affichage of table****************/
        public void affichageConge()
        {
            DataTable dataTable = control.SelectConge();
            dateTableConge.DataSource = dataTable;

        }


        /************bouton ajouter*************/
        private void InsertBtn_Click(object sender, EventArgs e)
        {
            ModalAjoutConge conge = new ModalAjoutConge(this);
            conge.Show();
        }
        
        /************bouton update*************/
        private void UpdateConge_Click(object sender, EventArgs e)
        {
            ModalUpdateConge update = new ModalUpdateConge(this);
            update.Show();
        }

        /************tadaGrid*************/
        private void dateTableConge_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateConge.Enabled = true;
            BtnDelete.Enabled = true;
            try
            {
                int rowIndex = e.RowIndex;
                ModalAjoutConge.numero = dateTableConge.Rows[rowIndex].Cells[0].Value.ToString();
                ModalAjoutConge.selectedValue = dateTableConge.Rows[rowIndex].Cells[1].Value.ToString();
                ModalAjoutConge.motif = dateTableConge.Rows[rowIndex].Cells[2].Value.ToString();
                ModalAjoutConge.variable1 = dateTableConge.Rows[rowIndex].Cells[4].Value.ToString();
                ModalAjoutConge.variable2 = dateTableConge.Rows[rowIndex].Cells[5].Value.ToString();

                int Nombre_de_jours;
                if (int.TryParse(dateTableConge.Rows[rowIndex].Cells[3].Value.ToString(), out Nombre_de_jours))
                {
                    ModalAjoutConge.nombrjr = Nombre_de_jours;
                }
                else
                {
                    MessageBox.Show("La valeur du salaire n'est pas un nombre entier valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                A = textId.Text = dateTableConge.Rows[rowIndex].Cells[0].Value.ToString();
                B = textNum.Text = dateTableConge.Rows[rowIndex].Cells[1].Value.ToString();
                textPointage.Text = dateTableConge.Rows[rowIndex].Cells[2].Value.ToString();
                
                textDate.Text = dateTableConge.Rows[rowIndex].Cells[3].Value.ToString();
                B = nombre.Text = dateTableConge.Rows[rowIndex].Cells[4].Value.ToString();
                dateRetour.Text = dateTableConge.Rows[rowIndex].Cells[5].Value.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /************bouton delete*************/
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            // Récupérer le numéro de congé à supprimer
            control.numConge = textId.Text;

            // Afficher une boîte de dialogue de confirmation
            DialogResult result = MessageBox.Show("Es-tu sûr de vouloir supprimer ce congé ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Vérifier la réponse de l'utilisateur
            if (result == DialogResult.Yes)
            {
                // Suppression si l'utilisateur a cliqué sur "Oui"
                bool success = control.DeleteConge(control);
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
            affichageConge();
            NoClick();
        }

        /************bouton nonClick*************/
        public void NoClick()
        {
            UpdateConge.Enabled = false;
            BtnDelete.Enabled = false;
        }
    }
}