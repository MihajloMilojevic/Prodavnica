namespace Prodavnica
{
    partial class PodaciOZaposlenom
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PodaciOZaposlenom));
            this.label1 = new System.Windows.Forms.Label();
            this.idTB = new System.Windows.Forms.TextBox();
            this.imeTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.prezimeTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.korisnickoImeTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ulogaCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.daniRadaTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.plataTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.datumZaposljenjaTB = new System.Windows.Forms.TextBox();
            this.dnevnicaNUD = new System.Windows.Forms.NumericUpDown();
            this.sacuvaj = new System.Windows.Forms.Button();
            this.izadji = new System.Windows.Forms.Button();
            this.otpusi = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dnevnicaNUD)).BeginInit();
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
            // imeTB
            // 
            this.imeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.imeTB.ForeColor = System.Drawing.Color.White;
            this.imeTB.Location = new System.Drawing.Point(242, 52);
            this.imeTB.Name = "imeTB";
            this.imeTB.Size = new System.Drawing.Size(291, 34);
            this.imeTB.TabIndex = 2;
            this.imeTB.TextChanged += new System.EventHandler(this.imeTB_TextChanged);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 34);
            this.label2.TabIndex = 2;
            this.label2.Text = "Ime:";
            // 
            // prezimeTB
            // 
            this.prezimeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.prezimeTB.ForeColor = System.Drawing.Color.White;
            this.prezimeTB.Location = new System.Drawing.Point(242, 92);
            this.prezimeTB.Name = "prezimeTB";
            this.prezimeTB.Size = new System.Drawing.Size(291, 34);
            this.prezimeTB.TabIndex = 3;
            this.prezimeTB.TextChanged += new System.EventHandler(this.prezimeTB_TextChanged);
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 92);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezime:";
            // 
            // korisnickoImeTB
            // 
            this.korisnickoImeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.korisnickoImeTB.ForeColor = System.Drawing.Color.White;
            this.korisnickoImeTB.Location = new System.Drawing.Point(242, 132);
            this.korisnickoImeTB.Name = "korisnickoImeTB";
            this.korisnickoImeTB.Size = new System.Drawing.Size(291, 34);
            this.korisnickoImeTB.TabIndex = 4;
            this.korisnickoImeTB.TextChanged += new System.EventHandler(this.korisnickoImeTB_TextChanged);
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 132);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(224, 34);
            this.label4.TabIndex = 6;
            this.label4.Text = "Korisničko ime:";
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(12, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(224, 34);
            this.label5.TabIndex = 8;
            this.label5.Text = "Uloga:";
            // 
            // ulogaCB
            // 
            this.ulogaCB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.ulogaCB.ForeColor = System.Drawing.Color.White;
            this.ulogaCB.FormattingEnabled = true;
            this.ulogaCB.Items.AddRange(new object[] {
            "admin",
            "magacin"});
            this.ulogaCB.Location = new System.Drawing.Point(242, 172);
            this.ulogaCB.Name = "ulogaCB";
            this.ulogaCB.Size = new System.Drawing.Size(291, 37);
            this.ulogaCB.TabIndex = 5;
            this.ulogaCB.SelectedIndexChanged += new System.EventHandler(this.ulogaCB_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(11, 215);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 65);
            this.label6.TabIndex = 10;
            this.label6.Text = "Datum zapošljenja:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 255);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 34);
            this.label7.TabIndex = 12;
            this.label7.Text = "Dnevnica:";
            // 
            // daniRadaTB
            // 
            this.daniRadaTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.daniRadaTB.ForeColor = System.Drawing.Color.White;
            this.daniRadaTB.Location = new System.Drawing.Point(242, 295);
            this.daniRadaTB.Name = "daniRadaTB";
            this.daniRadaTB.ReadOnly = true;
            this.daniRadaTB.Size = new System.Drawing.Size(291, 34);
            this.daniRadaTB.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.Location = new System.Drawing.Point(12, 295);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(224, 34);
            this.label8.TabIndex = 14;
            this.label8.Text = "Dana rada:";
            // 
            // plataTB
            // 
            this.plataTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.plataTB.ForeColor = System.Drawing.Color.White;
            this.plataTB.Location = new System.Drawing.Point(241, 335);
            this.plataTB.Name = "plataTB";
            this.plataTB.ReadOnly = true;
            this.plataTB.Size = new System.Drawing.Size(291, 34);
            this.plataTB.TabIndex = 9;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(11, 335);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(224, 34);
            this.label9.TabIndex = 16;
            this.label9.Text = "Plata:";
            // 
            // datumZaposljenjaTB
            // 
            this.datumZaposljenjaTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.datumZaposljenjaTB.ForeColor = System.Drawing.Color.White;
            this.datumZaposljenjaTB.Location = new System.Drawing.Point(241, 215);
            this.datumZaposljenjaTB.Name = "datumZaposljenjaTB";
            this.datumZaposljenjaTB.ReadOnly = true;
            this.datumZaposljenjaTB.Size = new System.Drawing.Size(291, 34);
            this.datumZaposljenjaTB.TabIndex = 6;
            // 
            // dnevnicaNUD
            // 
            this.dnevnicaNUD.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.dnevnicaNUD.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.dnevnicaNUD.ForeColor = System.Drawing.Color.White;
            this.dnevnicaNUD.Increment = new decimal(new int[] {
            50,
            0,
            0,
            0});
            this.dnevnicaNUD.Location = new System.Drawing.Point(241, 255);
            this.dnevnicaNUD.Maximum = new decimal(new int[] {
            100000,
            0,
            0,
            0});
            this.dnevnicaNUD.Name = "dnevnicaNUD";
            this.dnevnicaNUD.Size = new System.Drawing.Size(291, 34);
            this.dnevnicaNUD.TabIndex = 7;
            this.dnevnicaNUD.ValueChanged += new System.EventHandler(this.dnevnicaNUD_ValueChanged);
            // 
            // sacuvaj
            // 
            this.sacuvaj.BackColor = System.Drawing.Color.Transparent;
            this.sacuvaj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sacuvaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.sacuvaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.sacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sacuvaj.Location = new System.Drawing.Point(29, 400);
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
            this.izadji.Location = new System.Drawing.Point(380, 400);
            this.izadji.Name = "izadji";
            this.izadji.Size = new System.Drawing.Size(152, 60);
            this.izadji.TabIndex = 12;
            this.izadji.Text = "Izađi";
            this.izadji.UseVisualStyleBackColor = false;
            this.izadji.Click += new System.EventHandler(this.izadji_Click);
            // 
            // otpusi
            // 
            this.otpusi.BackColor = System.Drawing.Color.Transparent;
            this.otpusi.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.otpusi.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.otpusi.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.otpusi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.otpusi.Location = new System.Drawing.Point(202, 400);
            this.otpusi.Name = "otpusi";
            this.otpusi.Size = new System.Drawing.Size(152, 60);
            this.otpusi.TabIndex = 11;
            this.otpusi.Text = "Otpusti";
            this.otpusi.UseVisualStyleBackColor = false;
            this.otpusi.Click += new System.EventHandler(this.otpusi_Click);
            // 
            // PodaciOZaposlenom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(553, 486);
            this.Controls.Add(this.otpusi);
            this.Controls.Add(this.izadji);
            this.Controls.Add(this.sacuvaj);
            this.Controls.Add(this.dnevnicaNUD);
            this.Controls.Add(this.datumZaposljenjaTB);
            this.Controls.Add(this.plataTB);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.daniRadaTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ulogaCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.korisnickoImeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prezimeTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.imeTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.idTB);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "PodaciOZaposlenom";
            this.Text = "Podaci o Zaposlenom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PodaciOZaposlenom_FormClosing);
            this.Load += new System.EventHandler(this.PodaciOZaposlenom_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dnevnicaNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox idTB;
        private System.Windows.Forms.TextBox imeTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox prezimeTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox korisnickoImeTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ulogaCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox daniRadaTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox plataTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox datumZaposljenjaTB;
        private System.Windows.Forms.NumericUpDown dnevnicaNUD;
        private System.Windows.Forms.Button sacuvaj;
        private System.Windows.Forms.Button izadji;
        private System.Windows.Forms.Button otpusi;
    }
}