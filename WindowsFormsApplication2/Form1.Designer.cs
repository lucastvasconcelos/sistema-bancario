namespace WB.CaixaEletronico.principal
{
    partial class Form1
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
            this.textSaque = new System.Windows.Forms.TextBox();
            this.textDeposito = new System.Windows.Forms.TextBox();
            this.botaoDepositar = new System.Windows.Forms.Button();
            this.botaoSacar = new System.Windows.Forms.Button();
            this.textTitular = new System.Windows.Forms.TextBox();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboContas = new System.Windows.Forms.ComboBox();
            this.comboDestino = new System.Windows.Forms.ComboBox();
            this.comboOrigem = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.trans_display = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.buttonTransferir = new System.Windows.Forms.Button();
            this.textTransferencia = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textSaque
            // 
            this.textSaque.Location = new System.Drawing.Point(120, 183);
            this.textSaque.Name = "textSaque";
            this.textSaque.Size = new System.Drawing.Size(100, 20);
            this.textSaque.TabIndex = 1;
            // 
            // textDeposito
            // 
            this.textDeposito.Location = new System.Drawing.Point(2, 183);
            this.textDeposito.Name = "textDeposito";
            this.textDeposito.Size = new System.Drawing.Size(100, 20);
            this.textDeposito.TabIndex = 2;
            // 
            // botaoDepositar
            // 
            this.botaoDepositar.Location = new System.Drawing.Point(12, 209);
            this.botaoDepositar.Name = "botaoDepositar";
            this.botaoDepositar.Size = new System.Drawing.Size(75, 23);
            this.botaoDepositar.TabIndex = 3;
            this.botaoDepositar.Text = "Depositar";
            this.botaoDepositar.UseVisualStyleBackColor = true;
            this.botaoDepositar.Click += new System.EventHandler(this.button2_Click);
            // 
            // botaoSacar
            // 
            this.botaoSacar.Location = new System.Drawing.Point(136, 209);
            this.botaoSacar.Name = "botaoSacar";
            this.botaoSacar.Size = new System.Drawing.Size(75, 23);
            this.botaoSacar.TabIndex = 4;
            this.botaoSacar.Text = "Sacar";
            this.botaoSacar.UseVisualStyleBackColor = true;
            this.botaoSacar.Click += new System.EventHandler(this.button3_Click);
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(2, 94);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(209, 20);
            this.textTitular.TabIndex = 5;
            this.textTitular.TextChanged += new System.EventHandler(this.textTitular_TextChanged);
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(2, 134);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(209, 20);
            this.textSaldo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor atual na conta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Titular da conta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(40, 38);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 10;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // comboDestino
            // 
            this.comboDestino.FormattingEnabled = true;
            this.comboDestino.Location = new System.Drawing.Point(449, 95);
            this.comboDestino.Name = "comboDestino";
            this.comboDestino.Size = new System.Drawing.Size(121, 21);
            this.comboDestino.TabIndex = 11;
            this.comboDestino.SelectedIndexChanged += new System.EventHandler(this.comboDestino_SelectedIndexChanged);
            // 
            // comboOrigem
            // 
            this.comboOrigem.FormattingEnabled = true;
            this.comboOrigem.Location = new System.Drawing.Point(322, 94);
            this.comboOrigem.Name = "comboOrigem";
            this.comboOrigem.Size = new System.Drawing.Size(121, 21);
            this.comboOrigem.TabIndex = 12;
            this.comboOrigem.SelectedIndexChanged += new System.EventHandler(this.comboOrigem_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(358, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(40, 13);
            this.label3.TabIndex = 13;
            this.label3.Text = "Origem";
            // 
            // trans_display
            // 
            this.trans_display.AutoSize = true;
            this.trans_display.Location = new System.Drawing.Point(402, 59);
            this.trans_display.Name = "trans_display";
            this.trans_display.Size = new System.Drawing.Size(77, 13);
            this.trans_display.TabIndex = 14;
            this.trans_display.Text = "Transferencias";
            this.trans_display.Click += new System.EventHandler(this.label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(488, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 15;
            this.label5.Text = "Destino";
            // 
            // buttonTransferir
            // 
            this.buttonTransferir.Location = new System.Drawing.Point(404, 209);
            this.buttonTransferir.Name = "buttonTransferir";
            this.buttonTransferir.Size = new System.Drawing.Size(75, 23);
            this.buttonTransferir.TabIndex = 16;
            this.buttonTransferir.Text = "Transferir";
            this.buttonTransferir.UseVisualStyleBackColor = true;
            this.buttonTransferir.Click += new System.EventHandler(this.buttonTransferir_Click);
            // 
            // textTransferencia
            // 
            this.textTransferencia.Location = new System.Drawing.Point(392, 183);
            this.textTransferencia.Name = "textTransferencia";
            this.textTransferencia.Size = new System.Drawing.Size(100, 20);
            this.textTransferencia.TabIndex = 17;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(389, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 13);
            this.label6.TabIndex = 18;
            this.label6.Text = "Valor da transferência";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 258);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.textTransferencia);
            this.Controls.Add(this.buttonTransferir);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.trans_display);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboOrigem);
            this.Controls.Add(this.comboDestino);
            this.Controls.Add(this.comboContas);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textSaldo);
            this.Controls.Add(this.textTitular);
            this.Controls.Add(this.botaoSacar);
            this.Controls.Add(this.botaoDepositar);
            this.Controls.Add(this.textDeposito);
            this.Controls.Add(this.textSaque);
            this.Name = "Form1";
            this.Text = "Aplicações";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox textSaque;
        private System.Windows.Forms.TextBox textDeposito;
        private System.Windows.Forms.Button botaoDepositar;
        private System.Windows.Forms.Button botaoSacar;
        private System.Windows.Forms.TextBox textTitular;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboContas;
        private System.Windows.Forms.ComboBox comboDestino;
        private System.Windows.Forms.ComboBox comboOrigem;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label trans_display;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button buttonTransferir;
        private System.Windows.Forms.TextBox textTransferencia;
        private System.Windows.Forms.Label label6;
    }
}

