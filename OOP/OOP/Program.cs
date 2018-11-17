using System;


namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {

            Retangulo A = new Retangulo();
            Console.WriteLine("Digite o valor da Altura do Retangulo");
            A.altura = double.Parse(Console.ReadLine());
            Console.WriteLine("Digite o Valor da largura do Retangulo");
            A.largura = double.Parse(Console.ReadLine());

            Console.WriteLine("Area do Retangulo : " + A.area() + " Perimetro do Retangulo : " + A.perimetro() + " Diagonal " + A.diagonal());


            Console.ReadLine();


        }
    }
}
