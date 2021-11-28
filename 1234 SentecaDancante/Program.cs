using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1234_SentecaDancante
{
    class Program
    {
        static void Main(string[] args)
        {

            string sentence = Console.ReadLine();

            while (!string.IsNullOrWhiteSpace(sentence))
            {
                var charSentence = sentence.ToCharArray();
                var rs = "";
                var flag = true;
                for (var i = 0; i < charSentence.Length; i++)
                {
                    if (charSentence[i] != ' ')
                    {
                        if (flag)
                        {
                            rs += charSentence[i].ToString().ToUpper();
                        }
                        else
                        {
                            rs += sentence[i].ToString().ToLower();
                        }
                        flag = !flag;
                    }
                    else
                    {
                        rs += " ";
                    }
                }
                Console.WriteLine(rs);
                sentence = Console.ReadLine();
            }

        }

    }
}
