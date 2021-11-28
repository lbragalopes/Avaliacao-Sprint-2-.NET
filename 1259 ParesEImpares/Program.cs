using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1259_ParesEImpares
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = int.Parse(Console.ReadLine());

            int[] array = new int[N];


            for (int i = 0; i < N; i++)
            {

                array[i] = int.Parse(Console.ReadLine());

            }


            Array.Sort(array);
            for (int i = 0; i < N; i++)
            {
                if (array[i] % 2 == 0)
                    Console.WriteLine(array[i]);
            }
            Array.Reverse(array);
            for (int i = 0; i < N; i++)
            {
                if (array[i] % 2 != 0)
                    Console.WriteLine(array[i]);
            }


        }

    }
}