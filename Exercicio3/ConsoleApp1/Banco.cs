using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Banco
    {
        public int numeroConta;
        public string nomeTitular;
        public char indiceDeposito;
        public char indiceSaque;
        public double valorDeposito;
            
         public Banco (int numeroConta,string NomeDoTitular,double valorDoDeposito)
        {
            this.numeroConta = numeroConta;
            this.nomeTitular = NomeDoTitular;
            this.valorDeposito = valorDoDeposito;
        }

        public double ValorDoDeposito { get; }

        public void Deposito (double deposito)
        {
                valorDeposito = valorDeposito + deposito;
           
        }
        public void Saque(double saque)
        {
         
                valorDeposito = valorDeposito - saque -5;
        }
        
    }
}
