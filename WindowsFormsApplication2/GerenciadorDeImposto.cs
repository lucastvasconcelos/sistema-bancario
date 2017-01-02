using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WB.CaixaEletronico.exceptions;

namespace WB.CaixaEletronico.principal
{
    class GerenciadorDeImposto
    {
        public double Total { get; private set; }
        public void Adiciona(Tributavel tributavel)
        {
            Total += tributavel.CalculaTributo();
        }
    }
}
