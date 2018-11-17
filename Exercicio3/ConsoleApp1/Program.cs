using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Banco pessoa;
            Console.WriteLine("Digite o numero da sua conta bancaria");
            int id = int.Parse(Console.ReadLine());
            Console.WriteLine("Digite o nome do titular");
            string nome = Console.ReadLine();
            Console.WriteLine("Digite o valor inicial a ser depositado");
            double deposito = double.Parse(Console.ReadLine());

            pessoa = new Banco(id,nome,deposito);

            Console.WriteLine("Numero da Conta: " + pessoa.numeroConta + "Titular : " + pessoa.nomeTitular + "Valor atual em credito: " + pessoa.valorDeposito);
            Console.WriteLine("Gostaria de realizar um Deposito de quanto?");
            double depositoExtra = double.Parse(Console.ReadLine());
            pessoa.Deposito(depositoExtra);
            Console.WriteLine("Valor atual em conta: " + pessoa.valorDeposito);
            Console.WriteLine("Gostaria de realizar um saque de quanto?");
            double saque = double.Parse(Console.ReadLine());
            pessoa.Saque(saque);
            Console.WriteLine("Valor atual em conta: " + pessoa.valorDeposito);
            Console.ReadLine();


        }
    }
}
