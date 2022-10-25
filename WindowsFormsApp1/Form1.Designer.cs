namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblRA = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblN4 = new System.Windows.Forms.Label();
            this.lblN3 = new System.Windows.Forms.Label();
            this.lblN2 = new System.Windows.Forms.Label();
            this.lblN1 = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtRA = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.txtN1 = new System.Windows.Forms.TextBox();
            this.txtN2 = new System.Windows.Forms.TextBox();
            this.txtN4 = new System.Windows.Forms.TextBox();
            this.txtN3 = new System.Windows.Forms.TextBox();
            this.btnEnviar = new System.Windows.Forms.Button();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRA
            // 
            this.lblRA.AutoSize = true;
            this.lblRA.BackColor = System.Drawing.SystemColors.Control;
            this.lblRA.Location = new System.Drawing.Point(6, 16);
            this.lblRA.Name = "lblRA";
            this.lblRA.Size = new System.Drawing.Size(25, 13);
            this.lblRA.TabIndex = 0;
            this.lblRA.Text = "RA:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.groupBox1.Controls.Add(this.btnEnviar);
            this.groupBox1.Controls.Add(this.txtN3);
            this.groupBox1.Controls.Add(this.txtN4);
            this.groupBox1.Controls.Add(this.txtN2);
            this.groupBox1.Controls.Add(this.txtN1);
            this.groupBox1.Controls.Add(this.lblN4);
            this.groupBox1.Controls.Add(this.lblN3);
            this.groupBox1.Controls.Add(this.lblN2);
            this.groupBox1.Controls.Add(this.lblN1);
            this.groupBox1.Controls.Add(this.lblNome);
            this.groupBox1.Controls.Add(this.txtNome);
            this.groupBox1.Controls.Add(this.txtRA);
            this.groupBox1.Controls.Add(this.lblRA);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(271, 256);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // lblN4
            // 
            this.lblN4.AutoSize = true;
            this.lblN4.BackColor = System.Drawing.SystemColors.Control;
            this.lblN4.Location = new System.Drawing.Point(6, 185);
            this.lblN4.Name = "lblN4";
            this.lblN4.Size = new System.Drawing.Size(39, 13);
            this.lblN4.TabIndex = 7;
            this.lblN4.Text = "Nota 4";
            // 
            // lblN3
            // 
            this.lblN3.AutoSize = true;
            this.lblN3.BackColor = System.Drawing.SystemColors.Control;
            this.lblN3.Location = new System.Drawing.Point(6, 159);
            this.lblN3.Name = "lblN3";
            this.lblN3.Size = new System.Drawing.Size(39, 13);
            this.lblN3.TabIndex = 6;
            this.lblN3.Text = "Nota 3";
            // 
            // lblN2
            // 
            this.lblN2.AutoSize = true;
            this.lblN2.BackColor = System.Drawing.SystemColors.Control;
            this.lblN2.Location = new System.Drawing.Point(6, 133);
            this.lblN2.Name = "lblN2";
            this.lblN2.Size = new System.Drawing.Size(39, 13);
            this.lblN2.TabIndex = 5;
            this.lblN2.Text = "Nota 2";
            // 
            // lblN1
            // 
            this.lblN1.AutoSize = true;
            this.lblN1.BackColor = System.Drawing.SystemColors.Control;
            this.lblN1.Location = new System.Drawing.Point(6, 107);
            this.lblN1.Name = "lblN1";
            this.lblN1.Size = new System.Drawing.Size(39, 13);
            this.lblN1.TabIndex = 4;
            this.lblN1.Text = "Nota 1";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.BackColor = System.Drawing.SystemColors.Control;
            this.lblNome.Location = new System.Drawing.Point(6, 42);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(38, 13);
            this.lblNome.TabIndex = 3;
            this.lblNome.Text = "Nome:";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(83, 39);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(182, 20);
            this.txtNome.TabIndex = 2;
            // 
            // txtRA
            // 
            this.txtRA.Location = new System.Drawing.Point(83, 13);
            this.txtRA.Name = "txtRA";
            this.txtRA.Size = new System.Drawing.Size(182, 20);
            this.txtRA.TabIndex = 1;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column8,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(289, 14);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(843, 254);
            this.dataGridView1.TabIndex = 2;
            // 
            // txtN1
            // 
            this.txtN1.Location = new System.Drawing.Point(60, 104);
            this.txtN1.Name = "txtN1";
            this.txtN1.Size = new System.Drawing.Size(68, 20);
            this.txtN1.TabIndex = 8;
            // 
            // txtN2
            // 
            this.txtN2.Location = new System.Drawing.Point(60, 130);
            this.txtN2.Name = "txtN2";
            this.txtN2.Size = new System.Drawing.Size(68, 20);
            this.txtN2.TabIndex = 9;
            // 
            // txtN4
            // 
            this.txtN4.Location = new System.Drawing.Point(60, 182);
            this.txtN4.Name = "txtN4";
            this.txtN4.Size = new System.Drawing.Size(68, 20);
            this.txtN4.TabIndex = 10;
            // 
            // txtN3
            // 
            this.txtN3.Location = new System.Drawing.Point(60, 156);
            this.txtN3.Name = "txtN3";
            this.txtN3.Size = new System.Drawing.Size(68, 20);
            this.txtN3.TabIndex = 11;
            // 
            // btnEnviar
            // 
            this.btnEnviar.BackColor = System.Drawing.SystemColors.Control;
            this.btnEnviar.Location = new System.Drawing.Point(73, 222);
            this.btnEnviar.Name = "btnEnviar";
            this.btnEnviar.Size = new System.Drawing.Size(96, 23);
            this.btnEnviar.TabIndex = 12;
            this.btnEnviar.Text = "Enviar";
            this.btnEnviar.UseVisualStyleBackColor = false;
            this.btnEnviar.Click += new System.EventHandler(this.BtnEnviar_Click);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Nome";
            this.Column1.Name = "Column1";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "RA";
            this.Column8.Name = "Column8";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "N1";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.HeaderText = "N2";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.HeaderText = "N3";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "N4";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "Média";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Situação";
            this.Column7.Name = "Column7";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(1144, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblRA;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtRA;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label lblN4;
        private System.Windows.Forms.Label lblN3;
        private System.Windows.Forms.Label lblN2;
        private System.Windows.Forms.Label lblN1;
        private System.Windows.Forms.TextBox txtN3;
        private System.Windows.Forms.TextBox txtN4;
        private System.Windows.Forms.TextBox txtN2;
        private System.Windows.Forms.TextBox txtN1;
        private System.Windows.Forms.Button btnEnviar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
    }
}

