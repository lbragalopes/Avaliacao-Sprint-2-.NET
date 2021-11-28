using System;

class URI
{

    static void Main(string[] args)
    {

        string[] num = Console.ReadLine().Split(' ');
        int A = int.Parse(num[0]);
        int B = int.Parse(num[1]);
        int C = int.Parse(num[2]);

        int MaiorAB = (A + B + Math.Abs(A - B)) / 2;
        int Maior = (C + MaiorAB + Math.Abs(MaiorAB - C)) / 2;
        Console.WriteLine(Maior + " eh o maior");
        Console.ReadLine();

    }

}