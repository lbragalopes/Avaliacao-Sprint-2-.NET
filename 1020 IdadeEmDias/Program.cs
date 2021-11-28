using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1020_IdadeEmDias
{
    class Program
    {
        static void Main(string[] args)
        {

            int idade, anos, meses, dias, x;

            idade = int.Parse(Console.ReadLine());

            anos = idade / 365;
            x = idade % 365;
            meses = x / 30;
            dias = x % 30;

            Console.WriteLine(anos + " ano(s)");
            Console.WriteLine(meses + " mes(es)");
            Console.WriteLine(dias + " dia(s)");
        }

    }

}