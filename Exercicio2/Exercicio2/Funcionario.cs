using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio2
{
    class Funcionario
    {
        public string nome;
        public double salarioBruto;
        public double desconto;

        public double salarioLiquido()
        {
            return salarioBruto - desconto;
        }
        public void aumentarSalario(double porcentagem)
        {
            salarioBruto = ((salarioBruto * porcentagem)/100.00) + salarioBruto;
        }
    }
}
