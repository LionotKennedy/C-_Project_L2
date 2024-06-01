
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/****include******/
using Gestion.Route;

namespace Gestion.View
{
    public partial class FenetrePrincipal : Form
    {
        public FenetrePrincipal()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            navBar.Size = new Size(230, 812);
            MenuParametre.Visible = false;
            //***** first container *****//
            UserHome home = new UserHome();
            addUserControl(home);
        }

        //**** userControls*****//
        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            ContenuePanel.Controls.Clear();
            ContenuePanel.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void Closed_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Reduire_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void reduireMenu_Click(object sender, EventArgs e)
        {
            if(navBar.Width==230)
            {
                navBar.Size = new Size(58, 812);
            }
            else
            {
                navBar.Size = new Size(230, 812);
            }
        }

        private void parametre_Click(object sender, EventArgs e)
        {
            MenuParametre.Size = new Size(200, 221);
            MenuParametre.Visible = !MenuParametre.Visible;
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            UserHome home = new UserHome();
            addUserControl(home);
        }

        private void EmployesBtn_Click(object sender, EventArgs e)
        {
            UserEmployes employe = new UserEmployes();
            addUserControl(employe);
        }

        private void PointageBtn_Click(object sender, EventArgs e)
        {
            UserPointage pointage = new UserPointage();
            addUserControl(pointage);
        }

        private void CongeBtn_Click(object sender, EventArgs e)
        {
            UserConge conge = new UserConge();
            addUserControl(conge);
        }
    }
}
