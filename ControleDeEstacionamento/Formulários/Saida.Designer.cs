namespace ControleDeEstacionamento.Formulários
{
    partial class Saida
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
            this.grbTabelaPreco = new System.Windows.Forms.GroupBox();
            this.lblPreco1 = new System.Windows.Forms.Label();
            this.lblPreco3 = new System.Windows.Forms.Label();
            this.lblPreco2 = new System.Windows.Forms.Label();
            this.lblPreco4 = new System.Windows.Forms.Label();
            this.lblPreco5 = new System.Windows.Forms.Label();
            this.grbTabelaPreco.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbTabelaPreco
            // 
            this.grbTabelaPreco.Controls.Add(this.lblPreco5);
            this.grbTabelaPreco.Controls.Add(this.lblPreco4);
            this.grbTabelaPreco.Controls.Add(this.lblPreco2);
            this.grbTabelaPreco.Controls.Add(this.lblPreco3);
            this.grbTabelaPreco.Controls.Add(this.lblPreco1);
            this.grbTabelaPreco.Location = new System.Drawing.Point(44, 250);
            this.grbTabelaPreco.Name = "grbTabelaPreco";
            this.grbTabelaPreco.Size = new System.Drawing.Size(335, 163);
            this.grbTabelaPreco.TabIndex = 0;
            this.grbTabelaPreco.TabStop = false;
            this.grbTabelaPreco.Text = "Preços:";
            // 
            // lblPreco1
            // 
            this.lblPreco1.AutoSize = true;
            this.lblPreco1.Location = new System.Drawing.Point(23, 30);
            this.lblPreco1.Name = "lblPreco1";
            this.lblPreco1.Size = new System.Drawing.Size(137, 13);
            this.lblPreco1.TabIndex = 0;
            this.lblPreco1.Text = "Até 15 Minutos   -   R$ 0,00";
            // 
            // lblPreco3
            // 
            this.lblPreco3.AutoSize = true;
            this.lblPreco3.Location = new System.Drawing.Point(23, 53);
            this.lblPreco3.Name = "lblPreco3";
            this.lblPreco3.Size = new System.Drawing.Size(96, 13);
            this.lblPreco3.TabIndex = 1;
            this.lblPreco3.Text = "1 hora   -   R$ 5,00";
            // 
            // lblPreco2
            // 
            this.lblPreco2.AutoSize = true;
            this.lblPreco2.Location = new System.Drawing.Point(23, 66);
            this.lblPreco2.Name = "lblPreco2";
            this.lblPreco2.Size = new System.Drawing.Size(100, 13);
            this.lblPreco2.TabIndex = 2;
            this.lblPreco2.Text = "2 Horas   -   R$9,00";
            // 
            // lblPreco4
            // 
            this.lblPreco4.AutoSize = true;
            this.lblPreco4.Location = new System.Drawing.Point(23, 88);
            this.lblPreco4.Name = "lblPreco4";
            this.lblPreco4.Size = new System.Drawing.Size(35, 13);
            this.lblPreco4.TabIndex = 3;
            this.lblPreco4.Text = "label4";
            // 
            // lblPreco5
            // 
            this.lblPreco5.AutoSize = true;
            this.lblPreco5.Location = new System.Drawing.Point(71, 109);
            this.lblPreco5.Name = "lblPreco5";
            this.lblPreco5.Size = new System.Drawing.Size(35, 13);
            this.lblPreco5.TabIndex = 4;
            this.lblPreco5.Text = "label5";
            // 
            // Saida
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grbTabelaPreco);
            this.Name = "Saida";
            this.Text = "Saida";
            this.grbTabelaPreco.ResumeLayout(false);
            this.grbTabelaPreco.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbTabelaPreco;
        private System.Windows.Forms.Label lblPreco5;
        private System.Windows.Forms.Label lblPreco4;
        private System.Windows.Forms.Label lblPreco2;
        private System.Windows.Forms.Label lblPreco3;
        private System.Windows.Forms.Label lblPreco1;
    }
}