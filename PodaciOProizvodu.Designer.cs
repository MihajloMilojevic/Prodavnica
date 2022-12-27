namespace Prodavnica
{
    partial class PodaciOProizvodu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PodaciOProizvodu));
            this.label1 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.nazivTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.kolicinaNUD = new System.Windows.Forms.NumericUpDown();
            this.sacuvaj = new System.Windows.Forms.Button();
            this.izadji = new System.Windows.Forms.Button();
            this.ukoni = new System.Windows.Forms.Button();
            this.cenaNUD = new System.Windows.Forms.NumericUpDown();
            this.slika = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaNUD)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.slika)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 34);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID:";
            // 
            // idTB
            // 
            this.idTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.idTB.ForeColor = System.Drawing.Color.White;
            this.idTB.Location = new System.Drawing.Point(242, 12);
            this.idTB.Name = "idTB";
            this.idTB.ReadOnly = true;
            this.idTB.Size = new System.Drawing.Size(291, 34);
            this.idTB.TabIndex = 1;
            // 
            // nazivTB
            // 
            this.nazivTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.nazivTB.ForeColor = System.Drawing.Color.White;
            this.nazivTB.Location = new System.Drawing.Point(242, 52);
            this.nazivTB.Name = "nazivTB";
            this.nazivTB.Size = new System.Drawing.Size(291, 34);
            this.nazivTB.TabIndex = 2;
            this.nazivTB.TextChanged += new System.EventHandler(this.nazivTB_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Naziv:";
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Količina:";
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Cena:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Slika:";
            // 
            // kolicinaNUD
            // 
            this.kolicinaNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.kolicinaNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.kolicinaNUD.ForeColor = System.Drawing.Color.White;
            this.kolicinaNUD.Location = new System.Drawing.Point(241, 92);
            this.kolicinaNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.kolicinaNUD.Name = "kolicinaNUD";
            this.kolicinaNUD.Size = new System.Drawing.Size(291, 34);
            this.kolicinaNUD.TabIndex = 7;
            this.kolicinaNUD.ValueChanged += new System.EventHandler(this.kolicinaNUD_ValueChanged);
            // 
            // sacuvaj
            // 
            this.sacuvaj.BackColor = System.Drawing.Color.Transparent;
            this.sacuvaj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sacuvaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.sacuvaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.sacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sacuvaj.Location = new System.Drawing.Point(25, 607);
            this.sacuvaj.Name = "sacuvaj";
            this.sacuvaj.Size = new System.Drawing.Size(152, 60);
            this.sacuvaj.TabIndex = 10;
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
            this.izadji.Location = new System.Drawing.Point(376, 607);
            this.izadji.Name = "izadji";
            this.izadji.Size = new System.Drawing.Size(152, 60);
            this.izadji.TabIndex = 12;
            this.izadji.Text = "Izađi";
            this.izadji.UseVisualStyleBackColor = false;
            this.izadji.Click += new System.EventHandler(this.izadji_Click);
            // 
            // ukoni
            // 
            this.ukoni.BackColor = System.Drawing.Color.Transparent;
            this.ukoni.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.ukoni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.ukoni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.ukoni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ukoni.Location = new System.Drawing.Point(198, 607);
            this.ukoni.Name = "ukoni";
            this.ukoni.Size = new System.Drawing.Size(152, 60);
            this.ukoni.TabIndex = 11;
            this.ukoni.Text = "Izbriši";
            this.ukoni.UseVisualStyleBackColor = false;
            this.ukoni.Click += new System.EventHandler(this.ukoni_Click);
            // 
            // cenaNUD
            // 
            this.cenaNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.cenaNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.cenaNUD.DecimalPlaces = 2;
            this.cenaNUD.ForeColor = System.Drawing.Color.White;
            this.cenaNUD.Location = new System.Drawing.Point(242, 132);
            this.cenaNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.cenaNUD.Name = "cenaNUD";
            this.cenaNUD.Size = new System.Drawing.Size(291, 34);
            this.cenaNUD.TabIndex = 17;
            this.cenaNUD.ValueChanged += new System.EventHandler(this.cenaNUD_ValueChanged);
            // 
            // slika
            // 
            this.slika.Location = new System.Drawing.Point(121, 184);
            this.slika.Name = "slika";
            this.slika.Size = new System.Drawing.Size(400, 400);
            this.slika.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.slika.TabIndex = 18;
            this.slika.TabStop = false;
            // 
            // PodaciOProizvodu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(553, 679);
            this.Controls.Add(this.slika);
            this.Controls.Add(this.cenaNUD);
            this.Controls.Add(this.ukoni);
            this.Controls.Add(this.izadji);
            this.Controls.Add(this.sacuvaj);
            this.Controls.Add(this.kolicinaNUD);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.nazivTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "PodaciOProizvodu";
            this.Text = "Podaci o Zaposlenom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PodaciOProizvodu_FormClosing);
            this.Load += new System.EventHandler(this.PodaciOProizvodu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kolicinaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cenaNUD)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.slika)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox nazivTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.NumericUpDown kolicinaNUD;
        private System.Windows.Forms.Button sacuvaj;
        private System.Windows.Forms.Button izadji;
        private System.Windows.Forms.Button ukoni;
        private System.Windows.Forms.NumericUpDown cenaNUD;
        private System.Windows.Forms.PictureBox slika;
    }
}