using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace BroiniSistemi2
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // dec to bin
            int number = int.Parse(Console.ReadLine());
            string binary = "";
            while (number > 0)
            {
                binary += (number % 2).ToString();
                number /= 2;
            }
            binary = new string(binary.Reverse().ToArray());
            Console.WriteLine(binary);


            //dec to oct
            int number1 = int.Parse(Console.ReadLine());
            string oct = "";
            while (number1 > 0)
            {
                oct += (number1 % 8).ToString();
                number1 /= 8;
            }
            oct = new string(oct.Reverse().ToArray());
            Console.WriteLine(oct);

            // dec to hex
            int num = int.Parse(Console.ReadLine());
            string hex = "";

            while (num > 0)
            {
                int remainder = num % 16;
                switch (remainder)
                {
                    case 10: hex += "A"; break;
                    case 11: hex += "B"; break;
                    case 12: hex += "C"; break;
                    case 13: hex += "D"; break;
                    case 14: hex += "E"; break;
                    case 15: hex += "F"; break;
                    default: hex += remainder.ToString(); break;
                }

                num /= 16;
            }

            hex = new string(hex.Reverse().ToArray());
            Console.WriteLine(hex);

        }
    }
}
