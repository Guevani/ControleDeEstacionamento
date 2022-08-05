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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.grbEntrada = new System.Windows.Forms.GroupBox();
            this.lblmodelo = new System.Windows.Forms.Label();
            this.tbModelo = new System.Windows.Forms.TextBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.tbEntrada = new System.Windows.Forms.TextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.tbPlaca = new System.Windows.Forms.TextBox();
            this.btnCadastrarVaga = new System.Windows.Forms.Button();
            this.LblVaga = new System.Windows.Forms.Label();
            this.lblPlaca = new System.Windows.Forms.Label();
            this.gbSaida = new System.Windows.Forms.GroupBox();
            this.lblPlacaSaida = new System.Windows.Forms.Label();
            this.tbPlacaSaida = new System.Windows.Forms.TextBox();
            this.tbSaidaHora = new System.Windows.Forms.TextBox();
            this.lblSaida = new System.Windows.Forms.Label();
            this.cbSaida = new System.Windows.Forms.ComboBox();
            this.btSaida = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDADOS = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.grbEntrada.SuspendLayout();
            this.gbSaida.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDADOS)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.NullValue = null;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCellsExceptHeaders;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.Transparent;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(468, 284);
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
            this.grbEntrada.Location = new System.Drawing.Point(495, 53);
            this.grbEntrada.Name = "grbEntrada";
            this.grbEntrada.Size = new System.Drawing.Size(237, 212);
            this.grbEntrada.TabIndex = 1;
            this.grbEntrada.TabStop = false;
            this.grbEntrada.Text = "Entrada";
            // 
            // lblmodelo
            // 
            this.lblmodelo.AutoSize = true;
            this.lblmodelo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmodelo.Location = new System.Drawing.Point(25, 19);
            this.lblmodelo.Name = "lblmodelo";
            this.lblmodelo.Size = new System.Drawing.Size(72, 20);
            this.lblmodelo.TabIndex = 10;
            this.lblmodelo.Text = "Modelo:";
            // 
            // tbModelo
            // 
            this.tbModelo.Location = new System.Drawing.Point(103, 19);
            this.tbModelo.Multiline = true;
            this.tbModelo.Name = "tbModelo";
            this.tbModelo.Size = new System.Drawing.Size(100, 20);
            this.tbModelo.TabIndex = 9;
            // 
            // lblHora
            // 
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.Location = new System.Drawing.Point(25, 76);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(78, 20);
            this.lblHora.TabIndex = 8;
            this.lblHora.Text = "Entrada:";
            // 
            // tbEntrada
            // 
            this.tbEntrada.Enabled = false;
            this.tbEntrada.Location = new System.Drawing.Point(103, 78);
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
            this.comboBox1.Location = new System.Drawing.Point(103, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // tbPlaca
            // 
            this.tbPlaca.Location = new System.Drawing.Point(103, 52);
            this.tbPlaca.Multiline = true;
            this.tbPlaca.Name = "tbPlaca";
            this.tbPlaca.Size = new System.Drawing.Size(100, 18);
            this.tbPlaca.TabIndex = 5;
            // 
            // btnCadastrarVaga
            // 
            this.btnCadastrarVaga.Location = new System.Drawing.Point(103, 151);
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
            this.LblVaga.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblVaga.Location = new System.Drawing.Point(25, 110);
            this.LblVaga.Name = "LblVaga";
            this.LblVaga.Size = new System.Drawing.Size(65, 20);
            this.LblVaga.TabIndex = 2;
            this.LblVaga.Text = "Vagas:";
            // 
            // lblPlaca
            // 
            this.lblPlaca.AutoSize = true;
            this.lblPlaca.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlaca.Location = new System.Drawing.Point(25, 50);
            this.lblPlaca.Name = "lblPlaca";
            this.lblPlaca.Size = new System.Drawing.Size(58, 20);
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
            this.gbSaida.Location = new System.Drawing.Point(495, 384);
            this.gbSaida.Name = "gbSaida";
            this.gbSaida.Size = new System.Drawing.Size(214, 199);
            this.gbSaida.TabIndex = 2;
            this.gbSaida.TabStop = false;
            this.gbSaida.Text = "Saida";
            // 
            // lblPlacaSaida
            // 
            this.lblPlacaSaida.AutoSize = true;
            this.lblPlacaSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPlacaSaida.Location = new System.Drawing.Point(25, 36);
            this.lblPlacaSaida.Name = "lblPlacaSaida";
            this.lblPlacaSaida.Size = new System.Drawing.Size(58, 20);
            this.lblPlacaSaida.TabIndex = 11;
            this.lblPlacaSaida.Text = "Placa:";
            // 
            // tbPlacaSaida
            // 
            this.tbPlacaSaida.Location = new System.Drawing.Point(89, 38);
            this.tbPlacaSaida.Name = "tbPlacaSaida";
            this.tbPlacaSaida.Size = new System.Drawing.Size(100, 20);
            this.tbPlacaSaida.TabIndex = 10;
            // 
            // tbSaidaHora
            // 
            this.tbSaidaHora.Enabled = false;
            this.tbSaidaHora.Location = new System.Drawing.Point(89, 102);
            this.tbSaidaHora.Multiline = true;
            this.tbSaidaHora.Name = "tbSaidaHora";
            this.tbSaidaHora.Size = new System.Drawing.Size(100, 18);
            this.tbSaidaHora.TabIndex = 9;
            // 
            // lblSaida
            // 
            this.lblSaida.AutoSize = true;
            this.lblSaida.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSaida.Location = new System.Drawing.Point(25, 100);
            this.lblSaida.Name = "lblSaida";
            this.lblSaida.Size = new System.Drawing.Size(60, 20);
            this.lblSaida.TabIndex = 3;
            this.lblSaida.Text = "Saida:";
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
            this.cbSaida.Location = new System.Drawing.Point(89, 69);
            this.cbSaida.Name = "cbSaida";
            this.cbSaida.Size = new System.Drawing.Size(100, 21);
            this.cbSaida.TabIndex = 6;
            // 
            // btSaida
            // 
            this.btSaida.Location = new System.Drawing.Point(78, 137);
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
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(25, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Vagas:";
            // 
            // dgvDADOS
            // 
            this.dgvDADOS.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDADOS.Location = new System.Drawing.Point(12, 353);
            this.dgvDADOS.Name = "dgvDADOS";
            this.dgvDADOS.Size = new System.Drawing.Size(468, 262);
            this.dgvDADOS.TabIndex = 5;
            // 
            // Entrada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 646);
            this.Controls.Add(this.dgvDADOS);
            this.Controls.Add(this.gbSaida);
            this.Controls.Add(this.grbEntrada);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Entrada";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Entrada";
            this.Load += new System.EventHandler(this.Entrada_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.grbEntrada.ResumeLayout(false);
            this.grbEntrada.PerformLayout();
            this.gbSaida.ResumeLayout(false);
            this.gbSaida.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDADOS)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblmodelo;
        private System.Windows.Forms.TextBox tbModelo;
        private System.Windows.Forms.DataGridView dgvDADOS;
    }
}