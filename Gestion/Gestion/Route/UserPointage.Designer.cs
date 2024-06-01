namespace Gestion.Route
{
    partial class UserPointage
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
            this.btnAjouterPointage = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dataTablePointage = new System.Windows.Forms.DataGridView();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            this.guna2Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.BtnModifier = new Guna.UI2.WinForms.Guna2GradientButton();
            this.textPointage = new System.Windows.Forms.MaskedTextBox();
            this.textDate = new System.Windows.Forms.MaskedTextBox();
            this.textNum = new System.Windows.Forms.MaskedTextBox();
            this.textId = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePointage)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnAjouterPointage
            // 
            this.btnAjouterPointage.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouterPointage.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAjouterPointage.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouterPointage.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAjouterPointage.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAjouterPointage.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAjouterPointage.ForeColor = System.Drawing.Color.White;
            this.btnAjouterPointage.Location = new System.Drawing.Point(521, 653);
            this.btnAjouterPointage.Name = "btnAjouterPointage";
            this.btnAjouterPointage.Size = new System.Drawing.Size(205, 45);
            this.btnAjouterPointage.TabIndex = 0;
            this.btnAjouterPointage.Text = "Ajouter";
            this.btnAjouterPointage.Click += new System.EventHandler(this.btnAjouterPointage_Click);
            // 
            // dataTablePointage
            // 
            this.dataTablePointage.AllowUserToAddRows = false;
            this.dataTablePointage.AllowUserToDeleteRows = false;
            this.dataTablePointage.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataTablePointage.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTablePointage.Location = new System.Drawing.Point(61, 73);
            this.dataTablePointage.Name = "dataTablePointage";
            this.dataTablePointage.ReadOnly = true;
            this.dataTablePointage.RowHeadersWidth = 51;
            this.dataTablePointage.RowTemplate.Height = 24;
            this.dataTablePointage.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataTablePointage.Size = new System.Drawing.Size(1090, 483);
            this.dataTablePointage.TabIndex = 1;
            this.dataTablePointage.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTablePointage_CellClick_1);
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Controls.Add(this.BtnDelete);
            this.guna2CustomGradientPanel1.Controls.Add(this.guna2Button1);
            this.guna2CustomGradientPanel1.Controls.Add(this.BtnModifier);
            this.guna2CustomGradientPanel1.Controls.Add(this.textPointage);
            this.guna2CustomGradientPanel1.Controls.Add(this.textDate);
            this.guna2CustomGradientPanel1.Controls.Add(this.textNum);
            this.guna2CustomGradientPanel1.Controls.Add(this.textId);
            this.guna2CustomGradientPanel1.Controls.Add(this.dataTablePointage);
            this.guna2CustomGradientPanel1.Controls.Add(this.btnAjouterPointage);
            this.guna2CustomGradientPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(0, 0);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1192, 739);
            this.guna2CustomGradientPanel1.TabIndex = 0;
            // 
            // BtnDelete
            // 
            this.BtnDelete.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDelete.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDelete.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDelete.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDelete.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnDelete.ForeColor = System.Drawing.Color.White;
            this.BtnDelete.Location = new System.Drawing.Point(959, 653);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(192, 45);
            this.BtnDelete.TabIndex = 6;
            this.BtnDelete.Text = "Supprimer";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // guna2Button1
            // 
            this.guna2Button1.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.guna2Button1.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.guna2Button1.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.guna2Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.guna2Button1.ForeColor = System.Drawing.Color.White;
            this.guna2Button1.Location = new System.Drawing.Point(818, 663);
            this.guna2Button1.Name = "guna2Button1";
            this.guna2Button1.Size = new System.Drawing.Size(8, 8);
            this.guna2Button1.TabIndex = 5;
            this.guna2Button1.Text = "guna2Button1";
            // 
            // BtnModifier
            // 
            this.BtnModifier.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnModifier.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnModifier.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnModifier.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnModifier.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnModifier.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnModifier.ForeColor = System.Drawing.Color.White;
            this.BtnModifier.Location = new System.Drawing.Point(743, 653);
            this.BtnModifier.Name = "BtnModifier";
            this.BtnModifier.Size = new System.Drawing.Size(193, 45);
            this.BtnModifier.TabIndex = 4;
            this.BtnModifier.Text = "Modifier";
            this.BtnModifier.Click += new System.EventHandler(this.BtnModifier_Click);
            // 
            // textPointage
            // 
            this.textPointage.Location = new System.Drawing.Point(21, 363);
            this.textPointage.Name = "textPointage";
            this.textPointage.Size = new System.Drawing.Size(34, 22);
            this.textPointage.TabIndex = 3;
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(21, 403);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(33, 22);
            this.textDate.TabIndex = 3;
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(21, 319);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(34, 22);
            this.textNum.TabIndex = 3;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(21, 272);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(34, 22);
            this.textId.TabIndex = 2;
            // 
            // UserPointage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "UserPointage";
            this.Size = new System.Drawing.Size(1192, 739);
            ((System.ComponentModel.ISupportInitialize)(this.dataTablePointage)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton btnAjouterPointage;
        private System.Windows.Forms.DataGridView dataTablePointage;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private System.Windows.Forms.MaskedTextBox textPointage;
        private System.Windows.Forms.MaskedTextBox textDate;
        private System.Windows.Forms.MaskedTextBox textNum;
        private System.Windows.Forms.TextBox textId;
        private Guna.UI2.WinForms.Guna2Button guna2Button1;
        private Guna.UI2.WinForms.Guna2GradientButton BtnModifier;
        private Guna.UI2.WinForms.Guna2GradientButton BtnDelete;
    }
}
