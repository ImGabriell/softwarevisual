using System;

// Escrever um algoritmo que receba a altura e a largura de um retângulo 
// e calculea sua área.

namespace ex01
{
    class Program
    {
        
        static double CalcularArea(double largura, double altura) 
        {
            return largura * altura;
        }

        public static void Main(string[] args)
        {
            double largura = 0.0;
            double altura = 0.0;
            Console.WriteLine("Bem-vindo á calculadoera de área! XD");
            while (true)
            {
                try
                {
                    Console.WriteLine("Insira uma largura");
                    largura = double.Parse(Console.ReadLine());
                    break;
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            while (true)
            {
                try
                {
                    Console.WriteLine("Agora insira uma altura");
                    altura = double.Parse(Console.ReadLine()); 
                    break;
                }
                catch (System.Exception e)
                {
                    Console.WriteLine(e.Message);
                }
            }

            Console.WriteLine("A área é: " + CalcularArea(largura, altura));
            Console.Write("Pressione 'enter' para sair.");
            Console.ReadLine();
        }
    }
}
