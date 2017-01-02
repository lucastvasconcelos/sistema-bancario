using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WB.CaixaEletronico.exceptions;

namespace WB.CaixaEletronico.usuario
{
    class Cliente
    {
        public string nome;
        public string cpf;
        public string rg;
        public string endereço;
        public int idade;

        public Cliente(string nome,int idade,string cpf)
        {
            this.nome = nome;
            this.idade = idade;
            this.cpf = cpf;
           
        }


        public bool maiorDeIdade()
        {
            if (this.idade >= 18)
            {
                return true;
            }
            else
            {
                return false;
            }
        }   

    }
}
