using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            double aumento;
            Funcionario pessoa = new Funcionario();
            Console.WriteLine("Ditie o Nome do Funcionario");
            pessoa.nome = Console.ReadLine();
            Console.WriteLine("Digite o Salario do Funcionario");
            pessoa.salarioBruto = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o valor do desconto do funcionario");
            pessoa.desconto = double.Parse(Console.ReadLine());

            Console.WriteLine("Salario Liquido Do Funcionario" + pessoa.salarioLiquido());
            Console.WriteLine("Digite o aumento em porcentagem de 0 a 1 (sendo 0 = 0% e 1 = 100%)");
            aumento = double.Parse(Console.ReadLine());
            pessoa.aumentarSalario(aumento);
            Console.WriteLine("Novo Salario = " + pessoa.salarioBruto);
            Console.ReadLine();
        }
    }
}
