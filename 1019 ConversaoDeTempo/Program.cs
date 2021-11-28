using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1019_ConversaoDeTempo
{
    class Program
    {
        static void Main(string[] args)
        {
            int N, x, horas, minutos, segundos;

            N = int.Parse(Console.ReadLine());

            horas = N / 3600;
            x = N % 3600;

            minutos = x / 60;
            segundos = x % 60;

            Console.WriteLine(horas + ":" + minutos + ":" + segundos);

        }

    }
}