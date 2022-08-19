using System;

namespace Ex01ListCsharp2
{
    class Program
    {

        static double calculaMedia(double[] numeros)
        {
            double media = 0.0;
            double somas = 0.0;

            for (int i = 0; i < numeros.Length; i++)
            {
                somas += numeros[i]; //somas = somas + numeros[i];
            }

            media = somas / numeros.Length;

            return media;
        }

        static double calculaMediana(double[] numeros)
        {
            //Array.Sort(numeros);
            //int meio = numeros.Length / 2;

            //return numeros[meio];

            Array.Sort(numeros);
            int meio = numeros.Length / 2;
            if (numeros.Length % 2 == 0)
            {
                return numeros[meio] + numeros[meio - 1] / 2;
            }

            else
            {
                return numeros[meio];
            }

        }

        static void Main(string[] args)
        {

            double[] numeros = {123, 24, 12, 123, 763};
            double media = calculaMedia(numeros);
            Console.WriteLine("A média é: " + media);
            double mediana = calculaMediana(numeros);
            Console.WriteLine("A mediana é: " + mediana);

        }
    }
};
