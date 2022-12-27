namespace Prodavnica
{
    partial class DodajProizvod
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajProizvod));
            this.sacuvaj = new System.Windows.Forms.Button();
            this.izadji = new System.Windows.Forms.Button();
            this.nazivTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.kolicinaNUD = new System.Windows.Forms.NumericUpDown();
            this.cenaNUD = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.odaberiSliku = new System.Windows.Forms.Button();
            this.slikaPrikaz = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaPrikaz)).BeginInit();
            this.SuspendLayout();
            // 
            // sacuvaj
            // 
            this.sacuvaj.BackColor = System.Drawing.Color.Transparent;
            this.sacuvaj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sacuvaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.sacuvaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.sacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sacuvaj.Location = new System.Drawing.Point(85, 519);
            this.sacuvaj.Name = "sacuvaj";
            this.sacuvaj.Size = new System.Drawing.Size(152, 60);
            this.sacuvaj.TabIndex = 8;
            this.sacuvaj.Text = "Sačuvaj";
            this.sacuvaj.UseVisualStyleBackColor = false;
            this.sacuvaj.Click += new System.EventHandler(this.sacuvaj_Click);
            // 
            // izadji
            // 
            this.izadji.BackColor = System.Drawing.Color.Transparent;
            this.izadji.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.izadji.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.izadji.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.izadji.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.izadji.Location = new System.Drawing.Point(305, 519);
            this.izadji.Name = "izadji";
            this.izadji.Size = new System.Drawing.Size(152, 60);
            this.izadji.TabIndex = 9;
            this.izadji.Text = "Izađi";
            this.izadji.UseVisualStyleBackColor = false;
            this.izadji.Click += new System.EventHandler(this.izadji_Click);
            // 
            // nazivTB
            // 
            this.nazivTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.nazivTB.ForeColor = System.Drawing.Color.White;
            this.nazivTB.Location = new System.Drawing.Point(242, 12);
            this.nazivTB.Name = "nazivTB";
            this.nazivTB.Size = new System.Drawing.Size(262, 34);
            this.nazivTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "Naziv:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 52);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 34);
            this.label7.TabIndex = 28;
            this.label7.Text = "Kolicina:";
            // 
            // kolicinaNUD
            // 
            this.kolicinaNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.kolicinaNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kolicinaNUD.ForeColor = System.Drawing.Color.White;
            this.kolicinaNUD.Location = new System.Drawing.Point(242, 52);
            this.kolicinaNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.kolicinaNUD.Name = "kolicinaNUD";
            this.kolicinaNUD.Size = new System.Drawing.Size(261, 34);
            this.kolicinaNUD.TabIndex = 6;
            // 
            // cenaNUD
            // 
            this.cenaNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.cenaNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cenaNUD.DecimalPlaces = 2;
            this.cenaNUD.ForeColor = System.Drawing.Color.White;
            this.cenaNUD.Location = new System.Drawing.Point(242, 92);
            this.cenaNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.cenaNUD.Name = "cenaNUD";
            this.cenaNUD.Size = new System.Drawing.Size(261, 34);
            this.cenaNUD.TabIndex = 29;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 34);
            this.label2.TabIndex = 30;
            this.label2.Text = "Cena:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 34);
            this.label3.TabIndex = 31;
            this.label3.Text = "Slika:";
            // 
            // odaberiSliku
            // 
            this.odaberiSliku.BackColor = System.Drawing.Color.Transparent;
            this.odaberiSliku.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.odaberiSliku.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.odaberiSliku.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.odaberiSliku.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.odaberiSliku.Location = new System.Drawing.Point(242, 132);
            this.odaberiSliku.Name = "odaberiSliku";
            this.odaberiSliku.Size = new System.Drawing.Size(261, 48);
            this.odaberiSliku.TabIndex = 32;
            this.odaberiSliku.Text = "Odaberi sliku";
            this.odaberiSliku.UseVisualStyleBackColor = false;
            this.odaberiSliku.Click += new System.EventHandler(this.odaberiSliku_Click);
            // 
            // slikaPrikaz
            // 
            this.slikaPrikaz.Location = new System.Drawing.Point(134, 197);
            this.slikaPrikaz.Name = "slikaPrikaz";
            this.slikaPrikaz.Size = new System.Drawing.Size(300, 300);
            this.slikaPrikaz.TabIndex = 33;
            this.slikaPrikaz.TabStop = false;
            // 
            // DodajProizvod
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(553, 602);
            this.Controls.Add(this.slikaPrikaz);
            this.Controls.Add(this.odaberiSliku);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cenaNUD);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.kolicinaNUD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.nazivTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izadji);
            this.Controls.Add(this.sacuvaj);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "DodajProizvod";
            this.Text = "Podaci o Zaposlenom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DodajProizvod_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slikaPrikaz)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button sacuvaj;
        private System.Windows.Forms.Button izadji;
        private System.Windows.Forms.TextBox nazivTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown kolicinaNUD;
        private System.Windows.Forms.NumericUpDown cenaNUD;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button odaberiSliku;
        private System.Windows.Forms.PictureBox slikaPrikaz;
    }
}