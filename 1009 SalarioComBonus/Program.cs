using System;
using System.Globalization;

class URI
{

    static void Main(string[] args)
    {

        string nome = Console.ReadLine();
        double salfixo = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double vendas = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
        double total = salfixo + (vendas * 0.15);
        Console.WriteLine("TOTAL = R$ " + total.ToString("F2", CultureInfo.InvariantCulture));

        Console.ReadLine();
    }

}
