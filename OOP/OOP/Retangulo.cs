using System;


namespace OOP
{
    class Retangulo
    {
        public double altura, largura;

        public double area()
        {
            return (largura * altura);
        }
        public double perimetro()
        {
            return 2.0 * (largura + altura);
        }
        public double diagonal()
        {
            return Math.Sqrt(largura * largura + altura * altura);

        }
    }
}
