using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//*******include********//
using Gestion.Control;
using Gestion.Route;

namespace Gestion.View
{
    public partial class ModalEmployesUpdate : Form
    {
        public UserControl uc;
        public ModalEmployesUpdate(UserControl display)
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            UpdateControls();
            this.uc = display;
            updateNumero.Visible = false;
        }
        ControlEmployes control = new ControlEmployes();


        /******************************tsy haiky******************************/
        public void UpdateControls()
        {
            
            updateNumero.Text = ModalEmployes.numero;
            updateNom.Text = ModalEmployes.nom;
            updatePrenom.Text = ModalEmployes.prenom;
            updatePoste.Text = ModalEmployes.poste;
            updateSalaire.Text = ModalEmployes.salaire.ToString();
        }

        /******************************annuler bouton*******************************/
        private void AnnulerBtn_Click(object sender, EventArgs e)
        {
            this.Close();
            (uc as UserEmployes).NoClick();
        }


        /*******************************ajouter bouton*******************************/
        private void AjoouterBtn_Click(object sender, EventArgs e)
        {
            control.numEmp = updateNumero.Text;
            control.nomEmp = updateNom.Text;
            control.prenomEmp = updatePrenom.Text;
            control.post = updatePoste.Text;
            control.salaire = int.Parse(updateSalaire.Text);


            bool success = control.Update(control);
            if (success == true)
            {
                MessageBox.Show(" Mis a jours avec success");
                this.Close();
                (uc as UserEmployes).affichage();
                (uc as UserEmployes).NoClick();
            }
            else
            {
                MessageBox.Show("Ajout echec");
            }
        }
    }
}
