using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WB.CaixaEletronico.contas;

namespace WB.CaixaEletronico.principal
{
    class TotalizadorContas
    {
        public double Total;
        
        public void Adiciona(Conta c)
        {
            Total += c.Saldo;
        }
    }
}


