using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContaBancaria
{
    class ContaBancaria
    {   //ATRIBUTO
        public string NomeTitula { get; set; }
        public double NumConta { get; set;}
        public double Saldo { get; set; }

        //CONSTRUTOR
        public ContaBancaria(string nomeTitula, double numConta, double saldo)
        {
            this.NomeTitula = nomeTitula;  // Correto
            this.NumConta = numConta;        // Correto
            this.Saldo = saldo;

        }

        public string Exibir() 
        {
            return $"TITULA: {NomeTitula}\n NUMERO DA CONTA:{NumConta}\n  SALDO:{Saldo:c}";

        }


    }
}
