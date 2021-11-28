using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1244_OrdenacaoPorTamanho
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            for (int i = 0; i < n; i++)
            {

                String entrada = Console.ReadLine();
                String[] valoresEntrada = entrada.Split(' ');
                List<String> lista = new List<String>();
                foreach (string item in valoresEntrada)
                {
                    lista.Add(item);
                }
                while (lista.Count > 0)
                {
                    String palavraMaior = "";
                    foreach (string palavra in lista)
                    {
                        if (palavra.Length > palavraMaior.Length)
                        {
                            palavraMaior = palavra;
                        }
                    }
                    Console.Write(palavraMaior);
                    if (lista.Contains(palavraMaior))
                    {
                        lista.Remove(palavraMaior);
                    }
                    if (lista.Count > 0)
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
    }
}