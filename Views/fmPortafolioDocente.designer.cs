namespace Views
{
    partial class fmPortafolioDocente
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbSemestre = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dgvPortafolio = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buBuscarCV = new System.Windows.Forms.Button();
            this.buCV = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tbNombreDocente = new System.Windows.Forms.TextBox();
            this.tbCodDocente = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.buCerrar = new System.Windows.Forms.Button();
            this.buArchivar = new System.Windows.Forms.Button();
            this.buEditar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortafolio)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.groupBox2);
            this.panel3.Controls.Add(this.groupBox1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 51);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(432, 321);
            this.panel3.TabIndex = 5;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbSemestre);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgvPortafolio);
            this.groupBox2.Location = new System.Drawing.Point(20, 150);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox2.Size = new System.Drawing.Size(382, 237);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "ASIGNATURA";
            // 
            // cbSemestre
            // 
            this.cbSemestre.FormattingEnabled = true;
            this.cbSemestre.Location = new System.Drawing.Point(163, 28);
            this.cbSemestre.Margin = new System.Windows.Forms.Padding(2);
            this.cbSemestre.Name = "cbSemestre";
            this.cbSemestre.Size = new System.Drawing.Size(124, 21);
            this.cbSemestre.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(77, 28);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "SEMESTRE";
            // 
            // dgvPortafolio
            // 
            this.dgvPortafolio.AllowUserToAddRows = false;
            this.dgvPortafolio.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPortafolio.ColumnHeadersVisible = false;
            this.dgvPortafolio.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dgvPortafolio.Location = new System.Drawing.Point(42, 53);
            this.dgvPortafolio.Margin = new System.Windows.Forms.Padding(2);
            this.dgvPortafolio.Name = "dgvPortafolio";
            this.dgvPortafolio.RowTemplate.Height = 24;
            this.dgvPortafolio.Size = new System.Drawing.Size(316, 154);
            this.dgvPortafolio.TabIndex = 0;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Slabo";
            this.Column2.Name = "Column2";
            this.Column2.Width = 200;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "link";
            this.Column3.Name = "Column3";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buBuscarCV);
            this.groupBox1.Controls.Add(this.buCV);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.tbNombreDocente);
            this.groupBox1.Controls.Add(this.tbCodDocente);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(20, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox1.Size = new System.Drawing.Size(382, 119);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "DOCENTE";
            // 
            // buBuscarCV
            // 
            this.buBuscarCV.Location = new System.Drawing.Point(98, 78);
            this.buBuscarCV.Margin = new System.Windows.Forms.Padding(2);
            this.buBuscarCV.Name = "buBuscarCV";
            this.buBuscarCV.Size = new System.Drawing.Size(42, 25);
            this.buBuscarCV.TabIndex = 6;
            this.buBuscarCV.Text = "...";
            this.buBuscarCV.UseVisualStyleBackColor = true;
            // 
            // buCV
            // 
            this.buCV.Location = new System.Drawing.Point(152, 78);
            this.buCV.Margin = new System.Windows.Forms.Padding(2);
            this.buCV.Name = "buCV";
            this.buCV.Size = new System.Drawing.Size(77, 25);
            this.buCV.TabIndex = 5;
            this.buCV.Text = "VISUALIZAR";
            this.buCV.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 17);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "NOMBRE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 78);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(21, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "CV";
            // 
            // tbNombreDocente
            // 
            this.tbNombreDocente.BackColor = System.Drawing.SystemColors.Window;
            this.tbNombreDocente.Enabled = false;
            this.tbNombreDocente.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbNombreDocente.Location = new System.Drawing.Point(98, 15);
            this.tbNombreDocente.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombreDocente.Name = "tbNombreDocente";
            this.tbNombreDocente.Size = new System.Drawing.Size(262, 20);
            this.tbNombreDocente.TabIndex = 1;
            // 
            // tbCodDocente
            // 
            this.tbCodDocente.BackColor = System.Drawing.SystemColors.Window;
            this.tbCodDocente.Enabled = false;
            this.tbCodDocente.ForeColor = System.Drawing.SystemColors.InfoText;
            this.tbCodDocente.Location = new System.Drawing.Point(98, 47);
            this.tbCodDocente.Margin = new System.Windows.Forms.Padding(2);
            this.tbCodDocente.Name = "tbCodDocente";
            this.tbCodDocente.Size = new System.Drawing.Size(132, 20);
            this.tbCodDocente.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 50);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "CODIGO";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.buCerrar);
            this.panel2.Controls.Add(this.buArchivar);
            this.panel2.Controls.Add(this.buEditar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 372);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(432, 58);
            this.panel2.TabIndex = 4;
            // 
            // buCerrar
            // 
            this.buCerrar.Location = new System.Drawing.Point(276, 20);
            this.buCerrar.Margin = new System.Windows.Forms.Padding(2);
            this.buCerrar.Name = "buCerrar";
            this.buCerrar.Size = new System.Drawing.Size(75, 29);
            this.buCerrar.TabIndex = 2;
            this.buCerrar.Text = "CERRAR";
            this.buCerrar.UseVisualStyleBackColor = true;
            // 
            // buArchivar
            // 
            this.buArchivar.Location = new System.Drawing.Point(158, 20);
            this.buArchivar.Margin = new System.Windows.Forms.Padding(2);
            this.buArchivar.Name = "buArchivar";
            this.buArchivar.Size = new System.Drawing.Size(92, 29);
            this.buArchivar.TabIndex = 1;
            this.buArchivar.Text = "ARCHIVAR";
            this.buArchivar.UseVisualStyleBackColor = true;
            // 
            // buEditar
            // 
            this.buEditar.Location = new System.Drawing.Point(58, 20);
            this.buEditar.Margin = new System.Windows.Forms.Padding(2);
            this.buEditar.Name = "buEditar";
            this.buEditar.Size = new System.Drawing.Size(70, 29);
            this.buEditar.TabIndex = 0;
            this.buEditar.Text = "EDITAR";
            this.buEditar.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(432, 51);
            this.panel1.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(63, 7);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(278, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "PORTAFOLIO DOCENTE";
            // 
            // fmPortafolioDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(432, 430);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "fmPortafolioDocente";
            this.Text = "fmPortafolioDocente";
            this.panel3.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPortafolio)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cbSemestre;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DataGridView dgvPortafolio;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewLinkColumn Column3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buBuscarCV;
        private System.Windows.Forms.Button buCV;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox tbNombreDocente;
        private System.Windows.Forms.TextBox tbCodDocente;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button buCerrar;
        private System.Windows.Forms.Button buArchivar;
        private System.Windows.Forms.Button buEditar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
    }
}