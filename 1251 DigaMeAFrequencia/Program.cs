using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1251_DigaMeAFrequencia
{
    class Program
    {
        static void Main(string[] args)
        {

            string str = Console.ReadLine();
            while (!string.IsNullOrWhiteSpace(str))
            {
                var charLinq =
                    from ch in str
                    group ch by ch into groupChar
                    let g = new
                    {
                        ASCII = (int)groupChar.Key,
                        Count = groupChar.Count()
                    }
                    orderby g.ASCII descending
                    orderby g.Count
                    select g;
                foreach (var item in charLinq)
                    Console.WriteLine(item.ASCII + " " + item.Count);
                Console.WriteLine(" ");

                str = Console.ReadLine();

            }

        }
    }
}