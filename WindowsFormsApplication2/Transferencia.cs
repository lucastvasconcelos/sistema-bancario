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
        private Conta contaDestino;
        private Form1 aplicacaoPrincipal;
      
        public Transferencia(Form1 aplicacaoPrincipal)
        {
            InitializeComponent();
            this.aplicacaoPrincipal = aplicacaoPrincipal;
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

        public void carregarComboBox(Conta[] contas)
        {
            foreach(Conta conta in contas)
            {
                comboDestino.Items.Add(conta.titular.nome);
            }
        }

        private void comboDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexDestino = comboDestino.SelectedIndex;
            contaDestino = this.aplicacaoPrincipal.enviarContas(indexDestino);
        }
    }
}
 