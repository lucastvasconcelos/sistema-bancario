using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WB.CaixaEletronico.principal;
using WB.CaixaEletronico.contas;
using WB.CaixaEletronico.exceptions;

namespace WindowsFormsApplication2
{
    public partial class Transferencia : Form
    {
        Conta[] contas;
        private Conta contaDestino;
        private Form1 aplicacaoPrincipal;
        private Conta contaOrigem;
        private int i = 0;
        public Transferencia(Form1 aplicacaoPrincipal)
        {
            InitializeComponent();
            this.aplicacaoPrincipal = aplicacaoPrincipal;
            int tamanho_de_contas = this.aplicacaoPrincipal.numero_de_contas();
            this.contas = new Conta[tamanho_de_contas];
        }


        private void Transferencia_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
                 
            double valor = Convert.ToDouble(textValor.Text);
            try
            {
                this.aplicacaoPrincipal.Transferir(contaDestino, valor);
                labelTransferencia.Text = "Transferência realizada com sucesso";
            }
            catch(ContasIguaisException exception)
            {
                labelTransferencia.Text = "Ocorreu um erro na transferencia";
            }
            }

        public void carregarComboBox(Conta conta)
        {
            comboDestino.Items.Add(conta.titular.nome);
          
            this.contas[i] = conta;
            i++;
        }

        private void comboDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexDestino = comboDestino.SelectedIndex;
            contaDestino = contas[indexDestino];
        }

        public void recebe_contaOrigem(Conta c)
        {
            this.contaOrigem = c;
        }
    }
}
 