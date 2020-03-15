namespace eProdaja.WinUI.Korisnici
{
    partial class frmKorisnici
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Korisnici = new System.Windows.Forms.GroupBox();
            this.dgrvKorisnici = new System.Windows.Forms.DataGridView();
            this.btnPrikazi = new System.Windows.Forms.Button();
            this.txtPretragaKorisnika = new System.Windows.Forms.TextBox();
            this.Korisnici.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgrvKorisnici)).BeginInit();
            this.SuspendLayout();
            // 
            // Korisnici
            // 
            this.Korisnici.Controls.Add(this.dgrvKorisnici);
            this.Korisnici.Location = new System.Drawing.Point(12, 64);
            this.Korisnici.Name = "Korisnici";
            this.Korisnici.Size = new System.Drawing.Size(764, 364);
            this.Korisnici.TabIndex = 0;
            this.Korisnici.TabStop = false;
            this.Korisnici.Text = "Korisnici";
            // 
            // dgrvKorisnici
            // 
            this.dgrvKorisnici.AllowUserToAddRows = false;
            this.dgrvKorisnici.AllowUserToDeleteRows = false;
            this.dgrvKorisnici.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgrvKorisnici.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgrvKorisnici.Location = new System.Drawing.Point(3, 16);
            this.dgrvKorisnici.Name = "dgrvKorisnici";
            this.dgrvKorisnici.ReadOnly = true;
            this.dgrvKorisnici.Size = new System.Drawing.Size(758, 345);
            this.dgrvKorisnici.TabIndex = 0;
            // 
            // btnPrikazi
            // 
            this.btnPrikazi.Location = new System.Drawing.Point(642, 32);
            this.btnPrikazi.Name = "btnPrikazi";
            this.btnPrikazi.Size = new System.Drawing.Size(131, 23);
            this.btnPrikazi.TabIndex = 1;
            this.btnPrikazi.Text = "Prikazi";
            this.btnPrikazi.UseVisualStyleBackColor = true;
            this.btnPrikazi.Click += new System.EventHandler(this.btnPrikazi_Click);
            // 
            // txtPretragaKorisnika
            // 
            this.txtPretragaKorisnika.Location = new System.Drawing.Point(15, 35);
            this.txtPretragaKorisnika.Name = "txtPretragaKorisnika";
            this.txtPretragaKorisnika.Size = new System.Drawing.Size(370, 20);
            this.txtPretragaKorisnika.TabIndex = 2;
            // 
            // frmKorisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtPretragaKorisnika);
            this.Controls.Add(this.btnPrikazi);
            this.Controls.Add(this.Korisnici);
            this.Name = "frmKorisnici";
            this.Text = "frmKorisnici";
            this.Korisnici.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgrvKorisnici)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox Korisnici;
        private System.Windows.Forms.DataGridView dgrvKorisnici;
        private System.Windows.Forms.Button btnPrikazi;
        private System.Windows.Forms.TextBox txtPretragaKorisnika;
    }
}