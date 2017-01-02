using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WB.CaixaEletronico.principal;
using WB.CaixaEletronico.usuario;
using WB.CaixaEletronico.exceptions;

namespace WB.CaixaEletronico.contas
{
    class ContaPoupança : Conta,Tributavel
    {
        public ContaPoupança(Cliente cliente) : base(cliente)
        {

        }

        public override void Saca(double valor_saque)
        {
            if (valor_saque < 0)
            {
                throw new ArgumentException();
            }

            else if (valor_saque > 0 && valor_saque <= this.Saldo && titular.maiorDeIdade())
            {
                this.Saldo -= valor_saque + valor_saque * 0.01;
            }
            else if (valor_saque > 0 && valor_saque <= this.Saldo && titular.maiorDeIdade() == false)
            {
                this.Saldo -= 200 + 200 * 0.01 ;
            }
            else if (Double.IsNaN(valor_saque))
            {
                throw new FormatException();
            }
            else
            {
                throw new SaldoInsuficienteException();
            }
        }

        public double CalculaTributo()
        {
            return this.Saldo *= 0.03;
        }
    }
}
