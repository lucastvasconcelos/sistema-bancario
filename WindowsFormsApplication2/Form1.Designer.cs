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
            this.buttonTransferir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textSaque
            // 
            this.textSaque.Location = new System.Drawing.Point(130, 148);
            this.textSaque.Name = "textSaque";
            this.textSaque.Size = new System.Drawing.Size(100, 20);
            this.textSaque.TabIndex = 1;
            // 
            // textDeposito
            // 
            this.textDeposito.Location = new System.Drawing.Point(12, 148);
            this.textDeposito.Name = "textDeposito";
            this.textDeposito.Size = new System.Drawing.Size(100, 20);
            this.textDeposito.TabIndex = 2;
            // 
            // botaoDepositar
            // 
            this.botaoDepositar.Location = new System.Drawing.Point(22, 174);
            this.botaoDepositar.Name = "botaoDepositar";
            this.botaoDepositar.Size = new System.Drawing.Size(75, 23);
            this.botaoDepositar.TabIndex = 3;
            this.botaoDepositar.Text = "Depositar";
            this.botaoDepositar.UseVisualStyleBackColor = true;
            this.botaoDepositar.Click += new System.EventHandler(this.button2_Click);
            // 
            // botaoSacar
            // 
            this.botaoSacar.Location = new System.Drawing.Point(146, 174);
            this.botaoSacar.Name = "botaoSacar";
            this.botaoSacar.Size = new System.Drawing.Size(75, 23);
            this.botaoSacar.TabIndex = 4;
            this.botaoSacar.Text = "Sacar";
            this.botaoSacar.UseVisualStyleBackColor = true;
            this.botaoSacar.Click += new System.EventHandler(this.button3_Click);
            // 
            // textTitular
            // 
            this.textTitular.Location = new System.Drawing.Point(12, 59);
            this.textTitular.Name = "textTitular";
            this.textTitular.Size = new System.Drawing.Size(209, 20);
            this.textTitular.TabIndex = 5;
            this.textTitular.TextChanged += new System.EventHandler(this.textTitular_TextChanged);
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(12, 99);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(209, 20);
            this.textSaldo.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(69, 83);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Valor atual na conta";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Titular da conta";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // comboContas
            // 
            this.comboContas.FormattingEnabled = true;
            this.comboContas.Location = new System.Drawing.Point(60, 12);
            this.comboContas.Name = "comboContas";
            this.comboContas.Size = new System.Drawing.Size(121, 21);
            this.comboContas.TabIndex = 10;
            this.comboContas.SelectedIndexChanged += new System.EventHandler(this.comboContas_SelectedIndexChanged);
            // 
            // buttonTransferir
            // 
            this.buttonTransferir.Location = new System.Drawing.Point(75, 223);
            this.buttonTransferir.Name = "buttonTransferir";
            this.buttonTransferir.Size = new System.Drawing.Size(75, 23);
            this.buttonTransferir.TabIndex = 16;
            this.buttonTransferir.Text = "Transferir";
            this.buttonTransferir.UseVisualStyleBackColor = true;
            this.buttonTransferir.Click += new System.EventHandler(this.buttonTransferir_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(247, 258);
            this.Controls.Add(this.buttonTransferir);
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
        private System.Windows.Forms.Button buttonTransferir;
    }
}

