using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WB.CaixaEletronico.contas;
using WB.CaixaEletronico.usuario;
using WB.CaixaEletronico.exceptions;

namespace WB.CaixaEletronico.principal
{
    class ContaCorrente : ContaPoupança
    {
        public static int totalDeContasCorrentes = 0;
        public ContaCorrente(Cliente cliente) : base(cliente)
        {
            ContaCorrente.totalDeContasCorrentes++;
        }
        public override void Saca(double valor_saque)
        {
            if (valor_saque < 0)
            {
                throw new ArgumentException();
            }
            

            if (valor_saque > 0 && valor_saque <= this.Saldo && titular.maiorDeIdade())
            {
                this.Saldo -= valor_saque;
            }
            else if (valor_saque > 0 && valor_saque <= this.Saldo && titular.maiorDeIdade() == false)
            {
                this.Saldo -= 200;
            }
            
         
            else if(Double.IsNaN(valor_saque)){
                throw new FormatException();
            }

            else
            {
                throw new SaldoInsuficienteException();
            }
          
        }
    }
}
