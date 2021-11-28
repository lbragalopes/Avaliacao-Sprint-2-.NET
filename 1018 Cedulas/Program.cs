using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1018_Cedulas
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, notas100, notas50, notas20, notas10, notas5, notas2, notas1,
            resto, resto2, resto3, resto4, resto5, resto6;

            N = int.Parse(Console.ReadLine());

            if (0 < N && N < 1000000) { }

            Console.WriteLine(N);

            notas100 = N / 100;
            resto = N % 100;
            Console.WriteLine(notas100 + " nota(s) de R$ 100,00");

            notas50 = resto / 50;
            resto2 = resto % 50;
            Console.WriteLine(notas50 + " nota(s) de R$ 50,00");

            notas20 = resto2 / 20;
            resto3 = resto2 % 20;
            Console.WriteLine(notas20 + " nota(s) de R$ 20,00");

            notas10 = resto3 / 10;
            resto4 = resto3 % 10;
            Console.WriteLine(notas10 + " nota(s) de R$ 10,00");

            notas5 = resto4 / 5;
            resto5 = resto4 % 5;
            Console.WriteLine(notas5 + " nota(s) de R$ 5,00");

            notas2 = resto5 / 2;
            resto6 = resto5 % 2;
            Console.WriteLine(notas2 + " nota(s) de R$ 2,00");

            notas1 = resto6 / 1;
            Console.WriteLine(notas1 + " nota(s) de R$ 1,00");

            Console.ReadLine();
        }

    }
}