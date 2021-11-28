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
            List<Frequencia> lista = new List<Frequencia>();
            string entrada;
            bool flag = false;

            while ((entrada = Console.ReadLine()) != null)
            {
                if (flag)
                {
                    Console.WriteLine("");
                }
                for (int i = 0; i < entrada.Length; i++)
                {
                    int counter = 0;
                    char letter = entrada[i];
                    foreach (char c in entrada)
                    {
                        if (c == letter)
                        {
                            counter++;
                        }
                    }
                    entrada = entrada.Replace(letter, (char)0);
                    Frequencia f = new Frequencia(letter, counter);
                    lista.Add(f);
                }
                lista.Sort();
                foreach (Frequencia frequencia in lista)
                {
                    if (frequencia.Ascii != 0)
                    {
                        Console.WriteLine(frequencia.Ascii + " " + frequencia.Quantidade);
                    }
                }
                flag = true;
                lista.Clear();
            }
        }
    }

    class Frequencia : IComparable
    {
        public int Quantidade { get; set; }
        public int Ascii { get; private set; }
        public Frequencia(int ascii, int repetitions)
        {
            Quantidade = repetitions;
            Ascii = ascii;
        }
        public int CompareTo(object obj)
        {
            if (obj == null)
            {
                return 1;
            }
            Frequencia otherTest = obj as Frequencia;
            if (otherTest != null)
            {
                if (otherTest.Quantidade == this.Quantidade)
                {
                    if (otherTest.Ascii > this.Ascii)
                    {
                        return 1;
                    }
                    else
                    {
                        return -1;
                    }
                }
                return this.Quantidade.CompareTo(otherTest.Quantidade);
            }
            else
            {
                throw new ArgumentException("Não é possível dizer a frequencia!!");
            }
        }
    }
}