namespace Prodavnica
{
    partial class Magacin
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Magacin));
            this.footer = new System.Windows.Forms.Panel();
            this.dodaj = new System.Windows.Forms.Button();
            this.main = new System.Windows.Forms.Panel();
            this.tabela = new System.Windows.Forms.DataGridView();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.naziv = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cena = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kolicina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.footer.SuspendLayout();
            this.main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).BeginInit();
            this.SuspendLayout();
            // 
            // footer
            // 
            this.footer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.footer.Controls.Add(this.dodaj);
            this.footer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.footer.Location = new System.Drawing.Point(0, 357);
            this.footer.Name = "footer";
            this.footer.Size = new System.Drawing.Size(760, 94);
            this.footer.TabIndex = 0;
            // 
            // dodaj
            // 
            this.dodaj.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dodaj.BackColor = System.Drawing.Color.Transparent;
            this.dodaj.Cursor = System.Windows.Forms.Cursors.Default;
            this.dodaj.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dodaj.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkGray;
            this.dodaj.FlatAppearance.MouseOverBackColor = System.Drawing.Color.LightGray;
            this.dodaj.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dodaj.ForeColor = System.Drawing.Color.White;
            this.dodaj.Location = new System.Drawing.Point(234, 23);
            this.dodaj.Name = "dodaj";
            this.dodaj.Size = new System.Drawing.Size(321, 53);
            this.dodaj.TabIndex = 0;
            this.dodaj.Text = "Dodaj Proizvod";
            this.dodaj.UseVisualStyleBackColor = false;
            this.dodaj.Click += new System.EventHandler(this.dodaj_Click);
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.main.Controls.Add(this.tabela);
            this.main.Dock = System.Windows.Forms.DockStyle.Fill;
            this.main.Location = new System.Drawing.Point(0, 0);
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(760, 357);
            this.main.TabIndex = 1;
            // 
            // tabela
            // 
            this.tabela.AllowUserToAddRows = false;
            this.tabela.AllowUserToDeleteRows = false;
            this.tabela.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.tabela.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(170)))), ((int)(((byte)(229)))));
            this.tabela.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tabela.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.tabela.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabela.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.id,
            this.naziv,
            this.cena,
            this.kolicina});
            this.tabela.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabela.GridColor = System.Drawing.Color.White;
            this.tabela.Location = new System.Drawing.Point(0, 0);
            this.tabela.MultiSelect = false;
            this.tabela.Name = "tabela";
            this.tabela.ReadOnly = true;
            this.tabela.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.tabela.RowHeadersVisible = false;
            this.tabela.RowHeadersWidth = 70;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            this.tabela.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.tabela.RowTemplate.Height = 24;
            this.tabela.Size = new System.Drawing.Size(760, 357);
            this.tabela.TabIndex = 0;
            this.tabela.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tabela_CellDoubleClick);
            // 
            // id
            // 
            this.id.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.id.DefaultCellStyle = dataGridViewCellStyle1;
            this.id.HeaderText = "Id";
            this.id.MinimumWidth = 6;
            this.id.Name = "id";
            this.id.ReadOnly = true;
            this.id.Width = 62;
            // 
            // naziv
            // 
            this.naziv.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.naziv.DefaultCellStyle = dataGridViewCellStyle2;
            this.naziv.HeaderText = "Naziv";
            this.naziv.MinimumWidth = 6;
            this.naziv.Name = "naziv";
            this.naziv.ReadOnly = true;
            // 
            // cena
            // 
            this.cena.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.cena.DefaultCellStyle = dataGridViewCellStyle3;
            this.cena.HeaderText = "Cena";
            this.cena.MinimumWidth = 6;
            this.cena.Name = "cena";
            this.cena.ReadOnly = true;
            // 
            // kolicina
            // 
            this.kolicina.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.kolicina.DefaultCellStyle = dataGridViewCellStyle4;
            this.kolicina.HeaderText = "Količina";
            this.kolicina.MinimumWidth = 6;
            this.kolicina.Name = "kolicina";
            this.kolicina.ReadOnly = true;
            // 
            // Magacin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(14F, 29F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(760, 451);
            this.Controls.Add(this.main);
            this.Controls.Add(this.footer);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MinimumSize = new System.Drawing.Size(778, 411);
            this.Name = "Magacin";
            this.Text = "Administracija";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Magacin_FormClosing);
            this.Load += new System.EventHandler(this.Magacin_Load);
            this.footer.ResumeLayout(false);
            this.main.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tabela)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel footer;
        private System.Windows.Forms.Panel main;
        private System.Windows.Forms.DataGridView tabela;
        private System.Windows.Forms.Button dodaj;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn naziv;
        private System.Windows.Forms.DataGridViewTextBoxColumn cena;
        private System.Windows.Forms.DataGridViewTextBoxColumn kolicina;
    }
}