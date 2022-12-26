namespace Prodavnica
{
    partial class DodajZaposleog
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DodajZaposleog));
            this.prezimeTB = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.korisnickoImeTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ulogaCB = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.sacuvaj = new System.Windows.Forms.Button();
            this.izadji = new System.Windows.Forms.Button();
            this.imeTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datumZaposljavanjaMC = new System.Windows.Forms.MonthCalendar();
            this.lozinkaTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.dnevnicaNUD = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dnevnicaNUD)).BeginInit();
            this.SuspendLayout();
            // 
            // prezimeTB
            // 
            this.prezimeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.prezimeTB.ForeColor = System.Drawing.Color.White;
            this.prezimeTB.Location = new System.Drawing.Point(242, 52);
            this.prezimeTB.Name = "prezimeTB";
            this.prezimeTB.Size = new System.Drawing.Size(262, 34);
            this.prezimeTB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(12, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(224, 34);
            this.label3.TabIndex = 4;
            this.label3.Text = "Prezime:";
            // 
            // korisnickoImeTB
            // 
            this.korisnickoImeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.korisnickoImeTB.ForeColor = System.Drawing.Color.White;
            this.korisnickoImeTB.Location = new System.Drawing.Point(242, 92);
            this.korisnickoImeTB.Name = "korisnickoImeTB";
            this.korisnickoImeTB.Size = new System.Drawing.Size(262, 34);
            this.korisnickoImeTB.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(12, 92);
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
            "magacin",
            "kasa"});
            this.ulogaCB.Location = new System.Drawing.Point(242, 172);
            this.ulogaCB.Name = "ulogaCB";
            this.ulogaCB.Size = new System.Drawing.Size(262, 37);
            this.ulogaCB.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.Location = new System.Drawing.Point(12, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 40);
            this.label6.TabIndex = 10;
            this.label6.Text = "Datum zapošljenja:";
            // 
            // sacuvaj
            // 
            this.sacuvaj.BackColor = System.Drawing.Color.Transparent;
            this.sacuvaj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.sacuvaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.sacuvaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.sacuvaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sacuvaj.Location = new System.Drawing.Point(81, 480);
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
            this.izadji.Location = new System.Drawing.Point(301, 480);
            this.izadji.Name = "izadji";
            this.izadji.Size = new System.Drawing.Size(152, 60);
            this.izadji.TabIndex = 9;
            this.izadji.Text = "Izađi";
            this.izadji.UseVisualStyleBackColor = false;
            this.izadji.Click += new System.EventHandler(this.izadji_Click);
            // 
            // imeTB
            // 
            this.imeTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.imeTB.ForeColor = System.Drawing.Color.White;
            this.imeTB.Location = new System.Drawing.Point(242, 12);
            this.imeTB.Name = "imeTB";
            this.imeTB.Size = new System.Drawing.Size(262, 34);
            this.imeTB.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(224, 34);
            this.label1.TabIndex = 23;
            this.label1.Text = "Ime:";
            // 
            // datumZaposljavanjaMC
            // 
            this.datumZaposljavanjaMC.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.datumZaposljavanjaMC.FirstDayOfWeek = System.Windows.Forms.Day.Monday;
            this.datumZaposljavanjaMC.ForeColor = System.Drawing.Color.White;
            this.datumZaposljavanjaMC.Location = new System.Drawing.Point(242, 261);
            this.datumZaposljavanjaMC.MaxSelectionCount = 1;
            this.datumZaposljavanjaMC.Name = "datumZaposljavanjaMC";
            this.datumZaposljavanjaMC.TabIndex = 7;
            this.datumZaposljavanjaMC.TitleBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.datumZaposljavanjaMC.TitleForeColor = System.Drawing.Color.White;
            this.datumZaposljavanjaMC.TrailingForeColor = System.Drawing.Color.White;
            // 
            // lozinkaTB
            // 
            this.lozinkaTB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.lozinkaTB.ForeColor = System.Drawing.Color.White;
            this.lozinkaTB.Location = new System.Drawing.Point(242, 132);
            this.lozinkaTB.Name = "lozinkaTB";
            this.lozinkaTB.Size = new System.Drawing.Size(262, 34);
            this.lozinkaTB.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(12, 132);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(224, 34);
            this.label2.TabIndex = 26;
            this.label2.Text = "Lozinka:";
            // 
            // label7
            // 
            this.label7.Location = new System.Drawing.Point(12, 215);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(224, 34);
            this.label7.TabIndex = 28;
            this.label7.Text = "Dnevnica:";
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
            this.dnevnicaNUD.Location = new System.Drawing.Point(242, 215);
            this.dnevnicaNUD.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
            this.dnevnicaNUD.Name = "dnevnicaNUD";
            this.dnevnicaNUD.Size = new System.Drawing.Size(261, 34);
            this.dnevnicaNUD.TabIndex = 6;
            // 
            // DodajZaposleog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.ClientSize = new System.Drawing.Size(553, 563);
            this.Controls.Add(this.dnevnicaNUD);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.lozinkaTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.datumZaposljavanjaMC);
            this.Controls.Add(this.imeTB);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.izadji);
            this.Controls.Add(this.sacuvaj);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ulogaCB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.korisnickoImeTB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.prezimeTB);
            this.Controls.Add(this.label3);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(7);
            this.MaximizeBox = false;
            this.Name = "DodajZaposleog";
            this.Text = "Podaci o Zaposlenom";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DodajZaposleog_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.dnevnicaNUD)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox prezimeTB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox korisnickoImeTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox ulogaCB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button sacuvaj;
        private System.Windows.Forms.Button izadji;
        private System.Windows.Forms.TextBox imeTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MonthCalendar datumZaposljavanjaMC;
        private System.Windows.Forms.TextBox lozinkaTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.NumericUpDown dnevnicaNUD;
    }
}