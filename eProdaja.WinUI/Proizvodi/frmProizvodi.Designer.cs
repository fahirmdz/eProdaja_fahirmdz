namespace eProdaja.WinUI.Proizvodi
{
    partial class frmProizvodi
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
            this.txtSifra = new System.Windows.Forms.TextBox();
            this.txtNaziv = new System.Windows.Forms.TextBox();
            this.txtSlikaInput = new System.Windows.Forms.TextBox();
            this.txtCijena = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.slikaProizvod = new System.Windows.Forms.PictureBox();
            this.cmbVrstaProizvoda = new System.Windows.Forms.ComboBox();
            this.cmbJedMjere = new System.Windows.Forms.ComboBox();
            this.btnSacuvaj = new System.Windows.Forms.Button();
            this.btnDodajSliku = new System.Windows.Forms.Button();
            this.proizvodGrid = new System.Windows.Forms.DataGridView();
            this.ProizvodId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sifra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cijena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.VrstaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.JedinicaMjereId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Slika = new System.Windows.Forms.DataGridViewImageColumn();
            this.SlikaThumb = new System.Windows.Forms.DataGridViewImageColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)(this.slikaProizvod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtSifra
            // 
            this.txtSifra.Location = new System.Drawing.Point(133, 90);
            this.txtSifra.Name = "txtSifra";
            this.txtSifra.Size = new System.Drawing.Size(288, 20);
            this.txtSifra.TabIndex = 1;
            // 
            // txtNaziv
            // 
            this.txtNaziv.Location = new System.Drawing.Point(133, 116);
            this.txtNaziv.Name = "txtNaziv";
            this.txtNaziv.Size = new System.Drawing.Size(288, 20);
            this.txtNaziv.TabIndex = 2;
            // 
            // txtSlikaInput
            // 
            this.txtSlikaInput.Location = new System.Drawing.Point(133, 168);
            this.txtSlikaInput.Name = "txtSlikaInput";
            this.txtSlikaInput.Size = new System.Drawing.Size(288, 20);
            this.txtSlikaInput.TabIndex = 3;
            // 
            // txtCijena
            // 
            this.txtCijena.Location = new System.Drawing.Point(133, 142);
            this.txtCijena.Name = "txtCijena";
            this.txtCijena.Size = new System.Drawing.Size(100, 20);
            this.txtCijena.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Vrsta proizvoda:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 142);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Jed. mjere:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(79, 145);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Cijena: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 119);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Naziv:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(87, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(34, 13);
            this.label5.TabIndex = 10;
            this.label5.Text = "Sifra: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(79, 168);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(33, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Slika:";
            // 
            // slikaProizvod
            // 
            this.slikaProizvod.Location = new System.Drawing.Point(589, 28);
            this.slikaProizvod.Name = "slikaProizvod";
            this.slikaProizvod.Size = new System.Drawing.Size(143, 134);
            this.slikaProizvod.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.slikaProizvod.TabIndex = 12;
            this.slikaProizvod.TabStop = false;
            // 
            // cmbVrstaProizvoda
            // 
            this.cmbVrstaProizvoda.FormattingEnabled = true;
            this.cmbVrstaProizvoda.Location = new System.Drawing.Point(133, 61);
            this.cmbVrstaProizvoda.Name = "cmbVrstaProizvoda";
            this.cmbVrstaProizvoda.Size = new System.Drawing.Size(288, 21);
            this.cmbVrstaProizvoda.TabIndex = 13;
            this.cmbVrstaProizvoda.SelectedIndexChanged += new System.EventHandler(this.cmbVrstaProizvoda_SelectedIndexChanged);
            // 
            // cmbJedMjere
            // 
            this.cmbJedMjere.FormattingEnabled = true;
            this.cmbJedMjere.Location = new System.Drawing.Point(320, 139);
            this.cmbJedMjere.Name = "cmbJedMjere";
            this.cmbJedMjere.Size = new System.Drawing.Size(101, 21);
            this.cmbJedMjere.TabIndex = 14;
            // 
            // btnSacuvaj
            // 
            this.btnSacuvaj.Location = new System.Drawing.Point(565, 189);
            this.btnSacuvaj.Name = "btnSacuvaj";
            this.btnSacuvaj.Size = new System.Drawing.Size(186, 46);
            this.btnSacuvaj.TabIndex = 15;
            this.btnSacuvaj.Text = "Sacuvaj";
            this.btnSacuvaj.UseVisualStyleBackColor = true;
            this.btnSacuvaj.Click += new System.EventHandler(this.btnSacuvaj_Click);
            // 
            // btnDodajSliku
            // 
            this.btnDodajSliku.Location = new System.Drawing.Point(427, 164);
            this.btnDodajSliku.Name = "btnDodajSliku";
            this.btnDodajSliku.Size = new System.Drawing.Size(74, 26);
            this.btnDodajSliku.TabIndex = 16;
            this.btnDodajSliku.Text = "Dodaj";
            this.btnDodajSliku.UseVisualStyleBackColor = true;
            this.btnDodajSliku.Click += new System.EventHandler(this.btnDodajSliku_Click);
            // 
            // proizvodGrid
            // 
            this.proizvodGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.proizvodGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ProizvodId,
            this.Naziv,
            this.Sifra,
            this.Cijena,
            this.VrstaId,
            this.JedinicaMjereId,
            this.Slika,
            this.SlikaThumb,
            this.Status});
            this.proizvodGrid.Location = new System.Drawing.Point(2, 257);
            this.proizvodGrid.Name = "proizvodGrid";
            this.proizvodGrid.Size = new System.Drawing.Size(796, 181);
            this.proizvodGrid.TabIndex = 17;
            // 
            // ProizvodId
            // 
            this.ProizvodId.DataPropertyName = "ProizvodId";
            this.ProizvodId.HeaderText = "Proizvod ID";
            this.ProizvodId.Name = "ProizvodId";
            // 
            // Naziv
            // 
            this.Naziv.DataPropertyName = "Naziv";
            this.Naziv.HeaderText = "Naziv";
            this.Naziv.Name = "Naziv";
            // 
            // Sifra
            // 
            this.Sifra.DataPropertyName = "Sifra";
            this.Sifra.HeaderText = "Sifra";
            this.Sifra.Name = "Sifra";
            // 
            // Cijena
            // 
            this.Cijena.DataPropertyName = "Cijena";
            this.Cijena.HeaderText = "Cijena";
            this.Cijena.Name = "Cijena";
            // 
            // VrstaId
            // 
            this.VrstaId.DataPropertyName = "VrstaId";
            this.VrstaId.HeaderText = "VrstaId";
            this.VrstaId.Name = "VrstaId";
            // 
            // JedinicaMjereId
            // 
            this.JedinicaMjereId.DataPropertyName = "JedinicaMjereId";
            this.JedinicaMjereId.HeaderText = "JedinicaMjereId";
            this.JedinicaMjereId.Name = "JedinicaMjereId";
            // 
            // Slika
            // 
            this.Slika.DataPropertyName = "Slika";
            this.Slika.HeaderText = "Slika";
            this.Slika.Name = "Slika";
            this.Slika.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Slika.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // SlikaThumb
            // 
            this.SlikaThumb.DataPropertyName = "SlikaThumb";
            this.SlikaThumb.HeaderText = "SlikaThumb";
            this.SlikaThumb.Name = "SlikaThumb";
            this.SlikaThumb.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.SlikaThumb.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.Name = "Status";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // frmProizvodi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.proizvodGrid);
            this.Controls.Add(this.btnDodajSliku);
            this.Controls.Add(this.btnSacuvaj);
            this.Controls.Add(this.cmbJedMjere);
            this.Controls.Add(this.cmbVrstaProizvoda);
            this.Controls.Add(this.slikaProizvod);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtCijena);
            this.Controls.Add(this.txtSlikaInput);
            this.Controls.Add(this.txtNaziv);
            this.Controls.Add(this.txtSifra);
            this.Name = "frmProizvodi";
            this.Text = "g";
            this.Load += new System.EventHandler(this.frmProizvodi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.slikaProizvod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.proizvodGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtSifra;
        private System.Windows.Forms.TextBox txtNaziv;
        private System.Windows.Forms.TextBox txtSlikaInput;
        private System.Windows.Forms.TextBox txtCijena;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox slikaProizvod;
        private System.Windows.Forms.ComboBox cmbVrstaProizvoda;
        private System.Windows.Forms.ComboBox cmbJedMjere;
        private System.Windows.Forms.Button btnSacuvaj;
        private System.Windows.Forms.Button btnDodajSliku;
        private System.Windows.Forms.DataGridView proizvodGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ProizvodId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sifra;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cijena;
        private System.Windows.Forms.DataGridViewTextBoxColumn VrstaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn JedinicaMjereId;
        private System.Windows.Forms.DataGridViewImageColumn Slika;
        private System.Windows.Forms.DataGridViewImageColumn SlikaThumb;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}