using System;

namespace Aula02
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Informe uma largura:");
            // double area = CalculaArea(35.0, 3.0);
            // Console.WriteLine(area);
            double largura = Convert.ToDouble(Console.ReadLine()); // string ou var
            Console.WriteLine("Informe uma altura:");
            double altura = Convert.ToDouble(Console.ReadLine()); // string ou var
            double area = CalculaArea(largura, altura);
            Console.WriteLine("A área é: ");
            Console.WriteLine(area);
        }

        static double CalculaArea(double largura, double altura)
        {
            double area = largura * altura;
            return area;
        }
    }
}
