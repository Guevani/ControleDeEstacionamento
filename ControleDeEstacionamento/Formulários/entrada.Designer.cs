namespace ControleDeEstacionamento.Formulários
{
    partial class Entrada
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbEntrada = new System.Windows.Forms.GroupBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.btnCadastrarVaga = new System.Windows.Forms.Button();
            this.LblVaga = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.gbSaida = new System.Windows.Forms.GroupBox();
            this.cbSaida = new System.Windows.Forms.ComboBox();
            this.btSaida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblSaida = new System.Windows.Forms.Label();
            this.tbSaidaHora = new System.Windows.Forms.TextBox();
            this.tbPlacaSaida = new System.Windows.Forms.TextBox();
            this.lblPlacaSaida = new System.Windows.Forms.Label();
            this.lblvalor = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.dgvListartudo = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbEntrada.SuspendLayout();
            this.gbSaida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListartudo)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.NullValue = null;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Location = new System.Drawing.Point(751, 7);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(249, 300);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // grbEntrada
            // 
            this.grbEntrada.Controls.Add(this.lblmodelo);
            this.grbEntrada.Controls.Add(this.tbModelo);
            this.grbEntrada.Controls.Add(this.lblHora);
            this.grbEntrada.Controls.Add(this.tbEntrada);
            this.grbEntrada.Controls.Add(this.comboBox1);
            this.grbEntrada.Controls.Add(this.tbPlaca);
            this.grbEntrada.Controls.Add(this.btnCadastrarVaga);
            this.grbEntrada.Controls.Add(this.LblVaga);
            this.grbEntrada.Controls.Add(this.lblPlaca);
            this.grbEntrada.Location = new System.Drawing.Point(471, 7);
            this.grbEntrada.Name = "grbEntrada";
            this.grbEntrada.Size = new System.Drawing.Size(274, 204);
            this.grbEntrada.TabIndex = 1;
            this.grbEntrada.TabStop = false;
            this.grbEntrada.Text = "Entrada";
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Location = new System.Drawing.Point(88, 79);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(47, 13);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Entrada:";
            // 
            // tbEntrada
            // 
            this.tbEntrada.Enabled = false;
            this.tbEntrada.Location = new System.Drawing.Point(154, 76);
            this.tbEntrada.Multiline = true;
            this.tbEntrada.Name = "tbEntrada";
            this.tbEntrada.Size = new System.Drawing.Size(100, 18);
            this.tbEntrada.TabIndex = 7;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.comboBox1.Location = new System.Drawing.Point(154, 110);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(154, 44);
            this.tbPlaca.Multiline = true;
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(100, 18);
            this.tbPlaca.TabIndex = 5;
            // 
            // btnCadastrarVaga
            // 
            this.btnCadastrarVaga.Location = new System.Drawing.Point(91, 156);
            this.btnCadastrarVaga.Name = "btnCadastrarVaga";
            this.btnCadastrarVaga.Size = new System.Drawing.Size(111, 42);
            this.btnCadastrarVaga.TabIndex = 3;
            this.btnCadastrarVaga.Text = "Entrar";
            this.btnCadastrarVaga.UseVisualStyleBackColor = true;
            this.btnCadastrarVaga.Click += new System.EventHandler(this.btnCadastrarVaga_Click);
            // 
            // LblVaga
            // 
            this.LblVaga.AutoSize = true;
            this.LblVaga.Location = new System.Drawing.Point(88, 113);
            this.LblVaga.Name = "LblVaga";
            this.LblVaga.Size = new System.Drawing.Size(40, 13);
            this.LblVaga.TabIndex = 2;
            this.LblVaga.Text = "Vagas:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Location = new System.Drawing.Point(91, 44);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(37, 13);
            this.lblPlaca.TabIndex = 1;
            this.lblPlaca.Text = "Placa:";
            // 
            // gbSaida
            // 
            this.gbSaida.Controls.Add(this.lblPlacaSaida);
            this.gbSaida.Controls.Add(this.tbPlacaSaida);
            this.gbSaida.Controls.Add(this.tbSaidaHora);
            this.gbSaida.Controls.Add(this.lblSaida);
            this.gbSaida.Controls.Add(this.cbSaida);
            this.gbSaida.Controls.Add(this.btSaida);
            this.gbSaida.Controls.Add(this.label2);
            this.gbSaida.Location = new System.Drawing.Point(471, 228);
            this.gbSaida.Name = "gbSaida";
            this.gbSaida.Size = new System.Drawing.Size(274, 247);
            this.gbSaida.TabIndex = 2;
            this.gbSaida.TabStop = false;
            this.gbSaida.Text = "Saida";
            // 
            // cbSaida
            // 
            this.cbSaida.FormattingEnabled = true;
            this.cbSaida.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10"});
            this.cbSaida.Location = new System.Drawing.Point(154, 84);
            this.cbSaida.Name = "cbSaida";
            this.cbSaida.Size = new System.Drawing.Size(100, 21);
            this.cbSaida.TabIndex = 6;
            // 
            // btSaida
            // 
            this.btSaida.Location = new System.Drawing.Point(91, 179);
            this.btSaida.Name = "btSaida";
            this.btSaida.Size = new System.Drawing.Size(111, 42);
            this.btSaida.TabIndex = 3;
            this.btSaida.Text = "Saida";
            this.btSaida.UseVisualStyleBackColor = true;
            this.btSaida.Click += new System.EventHandler(this.btSaida_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vagas:";
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Location = new System.Drawing.Point(95, 126);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(37, 13);
            this.lblSaida.TabIndex = 3;
            this.lblSaida.Text = "Saida:";
            // 
            // tbSaidaHora
            // 
            this.tbSaidaHora.Enabled = false;
            this.tbSaidaHora.Location = new System.Drawing.Point(154, 126);
            this.tbSaidaHora.Multiline = true;
            this.tbSaidaHora.Name = "tbSaidaHora";
            this.tbSaidaHora.Size = new System.Drawing.Size(100, 18);
            this.tbSaidaHora.TabIndex = 9;
            // 
            // tbPlacaSaida
            // 
            this.tbPlacaSaida.Location = new System.Drawing.Point(154, 53);
            this.tbPlacaSaida.Name = "tbPlacaSaida";
            this.tbPlacaSaida.Size = new System.Drawing.Size(100, 20);
            this.tbPlacaSaida.TabIndex = 10;
            // 
            // lblPlacaSaida
            // 
            this.lblPlacaSaida.AutoSize = true;
            this.lblPlacaSaida.Location = new System.Drawing.Point(98, 56);
            this.lblPlacaSaida.Name = "lblPlacaSaida";
            this.lblPlacaSaida.Size = new System.Drawing.Size(34, 13);
            this.lblPlacaSaida.TabIndex = 11;
            this.lblPlacaSaida.Text = "carro:";
            // 
            // lblvalor
            // 
            this.lblvalor.AutoSize = true;
            this.lblvalor.Location = new System.Drawing.Point(856, 372);
            this.lblvalor.Name = "lblvalor";
            this.lblvalor.Size = new System.Drawing.Size(24, 13);
            this.lblvalor.TabIndex = 3;
            this.lblvalor.Text = "R$:";
            this.lblvalor.Click += new System.EventHandler(this.lblvalor_Click);
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(154, 19);
            this.tbModelo.Multiline = true;
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(100, 18);
            this.tbModelo.TabIndex = 9;
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Location = new System.Drawing.Point(88, 24);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(45, 13);
            this.lblmodelo.TabIndex = 10;
            this.lblmodelo.Text = "Modelo:";
            // 
            // dgvListartudo
            // 
            this.dgvListartudo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListartudo.Location = new System.Drawing.Point(12, 26);
            this.dgvListartudo.Name = "dgvListartudo";
            this.dgvListartudo.Size = new System.Drawing.Size(441, 150);
            this.dgvListartudo.TabIndex = 4;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 646);
            this.Controls.Add(this.dgvListartudo);
            this.Controls.Add(this.lblvalor);
            this.Controls.Add(this.gbSaida);
            this.Controls.Add(this.grbEntrada);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Entrada";
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.Entrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbEntrada.ResumeLayout(false);
            this.grbEntrada.PerformLayout();
            this.gbSaida.ResumeLayout(false);
            this.gbSaida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListartudo)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox grbEntrada;
        private System.Windows.Forms.Label LblVaga;
        private System.Windows.Forms.Label lblPlaca;
        private System.Windows.Forms.Button btnCadastrarVaga;
        private System.Windows.Forms.TextBox tbPlaca;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.TextBox tbEntrada;
        private System.Windows.Forms.GroupBox gbSaida;
        private System.Windows.Forms.ComboBox cbSaida;
        private System.Windows.Forms.Button btSaida;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbSaidaHora;
        private System.Windows.Forms.Label lblSaida;
        private System.Windows.Forms.Label lblPlacaSaida;
        private System.Windows.Forms.TextBox tbPlacaSaida;
        private System.Windows.Forms.Label lblvalor;
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.DataGridView dgvListartudo;
    }
}