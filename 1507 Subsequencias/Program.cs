using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1507_Subsequencias
{
    class Program
    {
              static void Main(string[] args)
        {
            int N;

            N = int.Parse(Console.ReadLine());

            for (int i = 0; i < N; i++)
            {
                string S = Console.ReadLine();
                int Q = int.Parse(Console.ReadLine());

                for (int j = 0; j < Q; j++)
                {
                    string query = Console.ReadLine();
                    string sub = "";
                    int queryPos = 0;
                    foreach (var c in S)
                    {
                        if (c == query[queryPos])
                        {
                            sub += c;
                            queryPos++;
                            if (queryPos >= query.Length)
                            {
                                break;
                            }
                        }
                    }
                    if (sub.Equals(query))
                    {
                        Console.WriteLine("Yes");
                    }
                    else
                    {
                        Console.WriteLine("No");
                    }
                }

            }
        }
    }
}