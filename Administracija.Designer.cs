namespace Prodavnica
{
    partial class Administracija
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
            this.tabela = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.prezime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.uloga = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danaRada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.danaDoKrajaUgovora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            this.tabela.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.ime,
            this.prezime,
            this.uloga,
            this.danaRada,
            this.danaDoKrajaUgovora});
            this.tabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabela.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.tabela.Location = new System.Drawing.Point(0, 0);
            this.tabela.Name = "tabela";
            this.tabela.ReadOnly = true;
            this.tabela.Size = new System.Drawing.Size(579, 354);
            this.tabela.TabIndex = 0;
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.id.HeaderText = "ID";
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 52;
            // 
            // ime
            // 
            this.ime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.ime.HeaderText = "Ime";
            this.ime.Name = "ime";
            this.ime.ReadOnly = true;
            this.ime.Width = 66;
            // 
            // prezime
            // 
            this.prezime.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.prezime.HeaderText = "Prezime";
            this.prezime.Name = "prezime";
            this.prezime.ReadOnly = true;
            this.prezime.Width = 104;
            // 
            // uloga
            // 
            this.uloga.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.uloga.HeaderText = "Uloga";
            this.uloga.Name = "uloga";
            this.uloga.ReadOnly = true;
            this.uloga.Width = 84;
            // 
            // danaRada
            // 
            this.danaRada.HeaderText = "Dana Rada";
            this.danaRada.Name = "danaRada";
            this.danaRada.ReadOnly = true;
            // 
            // danaDoKrajaUgovora
            // 
            this.danaDoKrajaUgovora.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.danaDoKrajaUgovora.HeaderText = "Dana Do Kraja Ugovora";
            this.danaDoKrajaUgovora.Name = "danaDoKrajaUgovora";
            this.danaDoKrajaUgovora.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tabela);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.panel1.Size = new System.Drawing.Size(579, 364);
            this.panel1.TabIndex = 1;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.panel2.Controls.Add(this.button1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 292);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(579, 72);
            this.panel2.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(62, 17);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(89, 42);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Administracija
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 364);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Administracija";
            this.Text = "Administracija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Administracija_FormClosing);
            this.Load += new System.EventHandler(this.Administracija_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn ime;
        private System.Windows.Forms.DataGridViewTextBoxColumn prezime;
        private System.Windows.Forms.DataGridViewTextBoxColumn uloga;
        private System.Windows.Forms.DataGridViewTextBoxColumn danaRada;
        private System.Windows.Forms.DataGridViewTextBoxColumn danaDoKrajaUgovora;
        private System.Windows.Forms.Button button1;
    }
}