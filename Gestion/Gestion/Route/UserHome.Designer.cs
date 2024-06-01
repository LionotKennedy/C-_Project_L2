namespace Gestion.Route
{
    partial class UserHome
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
            this.PanelHome = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.PanelHome.SuspendLayout();
            this.SuspendLayout();
            // 
            // PanelHome
            // 
            this.PanelHome.Controls.Add(this.label1);
            this.PanelHome.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelHome.Location = new System.Drawing.Point(0, 0);
            this.PanelHome.Name = "PanelHome";
            this.PanelHome.Size = new System.Drawing.Size(1192, 739);
            this.PanelHome.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(531, 284);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Coucou";
            // 
            // UserHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.PanelHome);
            this.Name = "UserHome";
            this.Size = new System.Drawing.Size(1192, 739);
            this.PanelHome.ResumeLayout(false);
            this.PanelHome.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2CustomGradientPanel PanelHome;
        private System.Windows.Forms.Label label1;
    }
}
