
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/**** include ***/
using Gestion.Control;
using Gestion.View;

namespace Gestion.Route
{
    public partial class UserEmployes : UserControl
    {
        public string keywordNom, keywordPrenom;
        public UserEmployes()
        {
            InitializeComponent();
            teste.Visible = false;
            teste2.Visible = false;
            teste3.Visible = false;
            teste4.Visible = false;
            teste5.Visible = false;
            delete.Visible = false;

            NoClick();
        }
        ControlEmployes control = new ControlEmployes();
        public void affichage()
        {
            DataTable dataTable = control.Select();
            dataTableEmployes2.DataSource = dataTable;

        }

        private void PanelEmployes_Paint(object sender, PaintEventArgs e)
        {
            DataTable dataTable2 = control.Select();
            dataTableEmployes2.DataSource = dataTable2;
        }

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ModalEmployes modal = new ModalEmployes(this);
            modal.Show();
        }

        private void dataTableEmployes2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            UpdateEmp.Enabled = true;
            DeleteBtn.Enabled = true;


            int rowIndex = e.RowIndex;
            ModalEmployes.numero = dataTableEmployes2.Rows[rowIndex].Cells[0].Value.ToString();
            ModalEmployes.nom = dataTableEmployes2.Rows[rowIndex].Cells[1].Value.ToString();
            ModalEmployes.prenom = dataTableEmployes2.Rows[rowIndex].Cells[2].Value.ToString();
            ModalEmployes.poste = dataTableEmployes2.Rows[rowIndex].Cells[3].Value.ToString();
            int salaire;
            if (int.TryParse(dataTableEmployes2.Rows[rowIndex].Cells[4].Value.ToString(), out salaire))
            {
                ModalEmployes.salaire = salaire;
            }
            else
            {
                MessageBox.Show("La valeur du salaire n'est pas un nombre entier valide.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            teste.Text = dataTableEmployes2.Rows[rowIndex].Cells[0].Value.ToString();
            delete.Text = dataTableEmployes2.Rows[rowIndex].Cells[0].Value.ToString();
            teste2.Text = dataTableEmployes2.Rows[rowIndex].Cells[1].Value.ToString();
            teste3.Text = dataTableEmployes2.Rows[rowIndex].Cells[2].Value.ToString();
            teste4.Text = dataTableEmployes2.Rows[rowIndex].Cells[3].Value.ToString();
            teste5.Text = dataTableEmployes2.Rows[rowIndex].Cells[4].Value.ToString();
            ModalEmployesUpdate update = new ModalEmployesUpdate(this);
            update.UpdateControls();
        }

        private void UpdateEmp_Click(object sender, EventArgs e)
        {
            ModalEmployesUpdate update = new ModalEmployesUpdate(this);
            update.Show();
        }

        private void DeleteBtn_Click(object sender, EventArgs e)
        {
            // Récupérer le numéro d'employé à supprimer
            control.numEmp = delete.Text;

            // Afficher une boîte de dialogue de confirmation
            DialogResult result = MessageBox.Show("Es-tu sûr de vouloir supprimer cet employé ?", "Confirmation de suppression", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

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
            affichage();
            NoClick();


        }

        /************bouton noclick*************/
        public void NoClick()
        {
            UpdateEmp.Enabled = false;
            DeleteBtn.Enabled = false;
        }


        /************bar de recherche*************/
        private void SearchBar_TextChanged(object sender, EventArgs e)
        {
            keywordPrenom = control.nomEmp = SearchBar.Text;
            keywordNom = control.prenomEmp = SearchBar.Text;    
            //MessageBox.Show(control.nomEmp, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);

            DataTable dataTable2 = control.Search();
            dataTableEmployes2.DataSource = dataTable2;

        }
    }
}
