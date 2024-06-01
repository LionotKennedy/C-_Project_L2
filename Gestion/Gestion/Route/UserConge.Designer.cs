namespace Gestion.Route
{
    partial class UserConge
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
            this.InsertBtn = new Guna.UI2.WinForms.Guna2GradientButton();
            this.dateTableConge = new System.Windows.Forms.DataGridView();
            this.UpdateConge = new Guna.UI2.WinForms.Guna2GradientButton();
            this.textPointage = new System.Windows.Forms.MaskedTextBox();
            this.textDate = new System.Windows.Forms.MaskedTextBox();
            this.textNum = new System.Windows.Forms.MaskedTextBox();
            this.textId = new System.Windows.Forms.TextBox();
            this.dateRetour = new System.Windows.Forms.MaskedTextBox();
            this.nombre = new System.Windows.Forms.MaskedTextBox();
            this.BtnDelete = new Guna.UI2.WinForms.Guna2GradientButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateTableConge)).BeginInit();
            this.SuspendLayout();
            // 
            // InsertBtn
            // 
            this.InsertBtn.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.InsertBtn.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.InsertBtn.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InsertBtn.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.InsertBtn.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.InsertBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.InsertBtn.ForeColor = System.Drawing.Color.White;
            this.InsertBtn.Location = new System.Drawing.Point(474, 657);
            this.InsertBtn.Name = "InsertBtn";
            this.InsertBtn.Size = new System.Drawing.Size(180, 45);
            this.InsertBtn.TabIndex = 0;
            this.InsertBtn.Text = "Ajouter";
            this.InsertBtn.Click += new System.EventHandler(this.InsertBtn_Click);
            // 
            // dateTableConge
            // 
            this.dateTableConge.AllowUserToAddRows = false;
            this.dateTableConge.AllowUserToDeleteRows = false;
            this.dateTableConge.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dateTableConge.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dateTableConge.Location = new System.Drawing.Point(57, 67);
            this.dateTableConge.Name = "dateTableConge";
            this.dateTableConge.ReadOnly = true;
            this.dateTableConge.RowHeadersWidth = 51;
            this.dateTableConge.RowTemplate.Height = 24;
            this.dateTableConge.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dateTableConge.Size = new System.Drawing.Size(1084, 495);
            this.dateTableConge.TabIndex = 1;
            this.dateTableConge.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dateTableConge_CellClick);
            // 
            // UpdateConge
            // 
            this.UpdateConge.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.UpdateConge.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.UpdateConge.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateConge.DisabledState.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.UpdateConge.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.UpdateConge.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UpdateConge.ForeColor = System.Drawing.Color.White;
            this.UpdateConge.Location = new System.Drawing.Point(714, 657);
            this.UpdateConge.Name = "UpdateConge";
            this.UpdateConge.Size = new System.Drawing.Size(179, 45);
            this.UpdateConge.TabIndex = 2;
            this.UpdateConge.Text = "Modifier";
            this.UpdateConge.Click += new System.EventHandler(this.UpdateConge_Click);
            // 
            // textPointage
            // 
            this.textPointage.Location = new System.Drawing.Point(21, 351);
            this.textPointage.Name = "textPointage";
            this.textPointage.Size = new System.Drawing.Size(24, 22);
            this.textPointage.TabIndex = 5;
            // 
            // textDate
            // 
            this.textDate.Location = new System.Drawing.Point(21, 478);
            this.textDate.Name = "textDate";
            this.textDate.Size = new System.Drawing.Size(30, 22);
            this.textDate.TabIndex = 6;
            // 
            // textNum
            // 
            this.textNum.Location = new System.Drawing.Point(21, 253);
            this.textNum.Name = "textNum";
            this.textNum.Size = new System.Drawing.Size(26, 22);
            this.textNum.TabIndex = 7;
            // 
            // textId
            // 
            this.textId.Location = new System.Drawing.Point(26, 172);
            this.textId.Name = "textId";
            this.textId.Size = new System.Drawing.Size(25, 22);
            this.textId.TabIndex = 4;
            // 
            // dateRetour
            // 
            this.dateRetour.Location = new System.Drawing.Point(21, 570);
            this.dateRetour.Name = "dateRetour";
            this.dateRetour.Size = new System.Drawing.Size(30, 22);
            this.dateRetour.TabIndex = 8;
            // 
            // nombre
            // 
            this.nombre.Location = new System.Drawing.Point(21, 402);
            this.nombre.Name = "nombre";
            this.nombre.Size = new System.Drawing.Size(30, 22);
            this.nombre.TabIndex = 9;
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
            this.BtnDelete.Location = new System.Drawing.Point(942, 657);
            this.BtnDelete.Name = "BtnDelete";
            this.BtnDelete.Size = new System.Drawing.Size(180, 45);
            this.BtnDelete.TabIndex = 10;
            this.BtnDelete.Text = "Supprimer";
            this.BtnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // UserConge
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.BtnDelete);
            this.Controls.Add(this.nombre);
            this.Controls.Add(this.dateRetour);
            this.Controls.Add(this.textPointage);
            this.Controls.Add(this.textDate);
            this.Controls.Add(this.textNum);
            this.Controls.Add(this.textId);
            this.Controls.Add(this.UpdateConge);
            this.Controls.Add(this.dateTableConge);
            this.Controls.Add(this.InsertBtn);
            this.Name = "UserConge";
            this.Size = new System.Drawing.Size(1192, 739);
            ((System.ComponentModel.ISupportInitialize)(this.dateTableConge)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GradientButton InsertBtn;
        private System.Windows.Forms.DataGridView dateTableConge;
        private Guna.UI2.WinForms.Guna2GradientButton UpdateConge;
        private System.Windows.Forms.MaskedTextBox textPointage;
        private System.Windows.Forms.MaskedTextBox textDate;
        private System.Windows.Forms.MaskedTextBox textNum;
        private System.Windows.Forms.TextBox textId;
        private System.Windows.Forms.MaskedTextBox dateRetour;
        private System.Windows.Forms.MaskedTextBox nombre;
        private Guna.UI2.WinForms.Guna2GradientButton BtnDelete;
    }
}
