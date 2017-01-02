using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WB.CaixaEletronico.usuario;
using WB.CaixaEletronico.contas;
using WB.CaixaEletronico.exceptions;
using WindowsFormsApplication2;

namespace WB.CaixaEletronico.principal
{
    public partial class Form1 : Form
    {
        Conta[] contas;
        Conta contaSelecionado;
        Conta contaOrigem;
        public Form1()
        {
            InitializeComponent();
        }

        //BOTÃO PARA DEPOSITO NO FORMULARIO
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                this.contaSelecionado.Deposita(Convert.ToDouble(textDeposito.Text));
            }
            catch (FormatException exception)
            {
                MessageBox.Show("Valor invalido");
            }
            MostrarConta(contaSelecionado);

        }

        //BOTÃO PARA REALIZAR O SAQUE
        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                this.contaSelecionado.Saca(Convert.ToDouble(textSaque.Text));
                MostrarConta(contaSelecionado);
            } catch (SaldoInsuficienteException expection)
            {
                MessageBox.Show("Saldo insuficiente");
            } catch (ArgumentException expection)
            {
                MessageBox.Show("Quantidade invalida");
            } catch (FormatException exception)
            {
                MessageBox.Show("Utilizar somente números");
            }
            

        }

        //"MAIN"
        private void Form1_Load(object sender, EventArgs e)
        {
            contas = new Conta[2];
            Cliente Lucas = new Cliente("Lucas Tavares Vasconcelos", 21, "06530209379");
            Cliente Roberto = new Cliente("Roberto Pereira", 30, "22222222");
            this.contas[0] = new ContaPoupança(Lucas);
            this.contas[0].Deposita(50);
            this.contas[1] = new ContaCorrente(Roberto);
            this.contas[1].Deposita(30);
            AdicionarNoBox(comboContas);
        }
        //METODO PARA ADICIONAR AS CONTAS NO COMBOBOX
        private void AdicionarNoBox(ComboBox C)
        {
            foreach (Conta conta in contas)
            {
                C.Items.Add(conta.titular.nome);
            }
        }

        //METODO PARA REALIZAR A ATUALIZAÇÃO NOS CAMPOS DE VALORES
        private void MostrarConta(Conta contaTransacao)
        {
            textTitular.Text = contaTransacao.titular.nome;
            textSaldo.Text = Convert.ToString(contaTransacao.Saldo);
            textDeposito.Text = "";
            textSaque.Text = "";
        }



        private void comboContas_SelectedIndexChanged(object sender, EventArgs e)
        {
            int indexSelecionado = comboContas.SelectedIndex;
            contaSelecionado = contas[indexSelecionado];
            MostrarConta(contaSelecionado);
        }
        //METODO DE TRANSFERENCIA QUE SERÁ UTILIZADO NO FORM TRANSFERENCIA
        public void Transferir(Conta c, double valor)
        {
            contaSelecionado.Transfere(valor, c);
            MostrarConta(contaSelecionado);
        }

        //BOTAO PARA INICIAR JANELA DE TRANSFÊNRENCIAS
        private void buttonTransferir_Click(object sender, EventArgs e)
        {
            Transferencia trans = new Transferencia(this);
            trans.recebe_contaOrigem(contaSelecionado);
            foreach (Conta conta in contas)
            {
                if (!conta.Equals(contaSelecionado))
                {
                    trans.carregarComboBox(conta);
                }
            }
            trans.ShowDialog();
        }

        public Conta enviarContas(int i)
        {
            return contas[i];
        }

        public int numero_de_contas()
        {
            return contas.Length;
        }
       

































       
        private void botaoConta_Click(object sender, EventArgs e)
        {

        }
        private void comboOrigem_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void comboDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }
        
        private void textTitular_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
    }
