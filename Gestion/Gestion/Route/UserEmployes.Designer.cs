namespace Gestion.Route
{
    partial class UserEmployes
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.dataTableEmployes2 = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new Guna.UI2.WinForms.Guna2GradientButton();
            this.teste = new System.Windows.Forms.TextBox();
            this.PanelEmployes = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.DeleteBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.UpdateEmp = new Guna.UI2.WinForms.Guna2GradientButton();
            this.teste5 = new System.Windows.Forms.MaskedTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.teste2 = new System.Windows.Forms.MaskedTextBox();
            this.teste3 = new System.Windows.Forms.TextBox();
            this.delete = new System.Windows.Forms.MaskedTextBox();
            this.teste4 = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SearchBar = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataTableEmployes2)).BeginInit();
            this.PanelEmployes.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataTableEmployes2
            // 
            this.dataTableEmployes2.AllowUserToAddRows = false;
            this.dataTableEmployes2.AllowUserToDeleteRows = false;
            this.dataTableEmployes2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTableEmployes2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTableEmployes2.Location = new System.Drawing.Point(99, 130);
            this.dataTableEmployes2.Name = "dataTableEmployes2";
            this.dataTableEmployes2.ReadOnly = true;
            this.dataTableEmployes2.RowHeadersWidth = 51;
            this.dataTableEmployes2.RowTemplate.Height = 24;
            this.dataTableEmployes2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTableEmployes2.Size = new System.Drawing.Size(1058, 497);
            this.dataTableEmployes2.TabIndex = 0;
            this.dataTableEmployes2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTableEmployes2_CellClick);
            // 
            // btnAjouter
            // 
            this.btnAjouter.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouter.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouter.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouter.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouter.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAjouter.ForeColor = System.Drawing.Color.White;
            this.btnAjouter.Location = new System.Drawing.Point(527, 658);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(204, 45);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "Ajouter";
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // teste
            // 
            this.teste.Location = new System.Drawing.Point(24, 84);
            this.teste.Name = "teste";
            this.teste.Size = new System.Drawing.Size(36, 22);
            this.teste.TabIndex = 7;
            // 
            // PanelEmployes
            // 
            this.PanelEmployes.Controls.Add(this.label1);
            this.PanelEmployes.Controls.Add(this.SearchBar);
            this.PanelEmployes.Controls.Add(this.DeleteBtn);
            this.PanelEmployes.Controls.Add(this.UpdateEmp);
            this.PanelEmployes.Controls.Add(this.teste5);
            this.PanelEmployes.Controls.Add(this.textBox1);
            this.PanelEmployes.Controls.Add(this.teste2);
            this.PanelEmployes.Controls.Add(this.teste3);
            this.PanelEmployes.Controls.Add(this.delete);
            this.PanelEmployes.Controls.Add(this.teste4);
            this.PanelEmployes.Controls.Add(this.teste);
            this.PanelEmployes.Controls.Add(this.btnAjouter);
            this.PanelEmployes.Controls.Add(this.dataTableEmployes2);
            this.PanelEmployes.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelEmployes.Location = new System.Drawing.Point(0, 0);
            this.PanelEmployes.Name = "PanelEmployes";
            this.PanelEmployes.Size = new System.Drawing.Size(1192, 739);
            this.PanelEmployes.TabIndex = 0;
            this.PanelEmployes.Paint += new System.Windows.Forms.PaintEventHandler(this.PanelEmployes_Paint);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.DeleteBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.DeleteBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.DeleteBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteBtn.ForeColor = System.Drawing.Color.White;
            this.DeleteBtn.Location = new System.Drawing.Point(962, 658);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(180, 45);
            this.DeleteBtn.TabIndex = 15;
            this.DeleteBtn.Text = "Supprimer";
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // UpdateEmp
            // 
            this.UpdateEmp.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateEmp.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateEmp.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateEmp.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateEmp.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateEmp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateEmp.ForeColor = System.Drawing.Color.White;
            this.UpdateEmp.Location = new System.Drawing.Point(758, 658);
            this.UpdateEmp.Name = "UpdateEmp";
            this.UpdateEmp.Size = new System.Drawing.Size(180, 45);
            this.UpdateEmp.TabIndex = 14;
            this.UpdateEmp.Text = "Modifier";
            this.UpdateEmp.Click += new System.EventHandler(this.UpdateEmp_Click);
            // 
            // teste5
            // 
            this.teste5.Location = new System.Drawing.Point(24, 322);
            this.teste5.Name = "teste5";
            this.teste5.Size = new System.Drawing.Size(36, 22);
            this.teste5.TabIndex = 13;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(-16, -28);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 22);
            this.textBox1.TabIndex = 12;
            // 
            // teste2
            // 
            this.teste2.Location = new System.Drawing.Point(24, 182);
            this.teste2.Name = "teste2";
            this.teste2.Size = new System.Drawing.Size(36, 22);
            this.teste2.TabIndex = 11;
            // 
            // teste3
            // 
            this.teste3.Location = new System.Drawing.Point(24, 230);
            this.teste3.Name = "teste3";
            this.teste3.Size = new System.Drawing.Size(36, 22);
            this.teste3.TabIndex = 10;
            // 
            // delete
            // 
            this.delete.Location = new System.Drawing.Point(24, 130);
            this.delete.Name = "delete";
            this.delete.Size = new System.Drawing.Size(36, 22);
            this.delete.TabIndex = 9;
            // 
            // teste4
            // 
            this.teste4.Location = new System.Drawing.Point(24, 276);
            this.teste4.Name = "teste4";
            this.teste4.Size = new System.Drawing.Size(36, 22);
            this.teste4.TabIndex = 8;
            // 
            // SearchBar
            // 
            this.SearchBar.Location = new System.Drawing.Point(674, 57);
            this.SearchBar.Multiline = true;
            this.SearchBar.Name = "SearchBar";
            this.SearchBar.Size = new System.Drawing.Size(483, 32);
            this.SearchBar.TabIndex = 16;
            this.SearchBar.TextChanged += new System.EventHandler(this.SearchBar_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(421, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(215, 25);
            this.label1.TabIndex = 17;
            this.label1.Text = "Recherche Employes";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // UserEmployes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelEmployes);
            this.Name = "UserEmployes";
            this.Size = new System.Drawing.Size(1192, 739);
            ((System.ComponentModel.ISupportInitialize)(this.dataTableEmployes2)).EndInit();
            this.PanelEmployes.ResumeLayout(false);
            this.PanelEmployes.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataTableEmployes2;
        private Guna.UI2.WinForms.Guna2GradientButton btnAjouter;
        private System.Windows.Forms.TextBox teste;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelEmployes;
        private System.Windows.Forms.MaskedTextBox teste2;
        private System.Windows.Forms.TextBox teste3;
        private System.Windows.Forms.MaskedTextBox delete;
        private System.Windows.Forms.TextBox teste4;
        private System.Windows.Forms.MaskedTextBox teste5;
        private System.Windows.Forms.TextBox textBox1;
        private Guna.UI2.WinForms.Guna2GradientButton UpdateEmp;
        private Guna.UI2.WinForms.Guna2GradientButton DeleteBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox SearchBar;
        private System.Windows.Forms.Label label1;
    }
}
