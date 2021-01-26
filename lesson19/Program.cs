using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson19
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double n1 = double.Parse(Console.ReadLine());
                double n2 = double.Parse(Console.ReadLine());
                string sigh = Console.ReadLine();
                switch (sigh)
                {
                    case "+":
                        Console.WriteLine("Answer" + (n1 + n2));
                        break;
                    case "-":
                        Console.WriteLine("Answer" + (n1 - n2));
                        break;
                    case "*":
                        Console.WriteLine("Answer" + (n1 * n2));
                        break;
                    case "/":
                        if (n2 == 0)
                            Console.WriteLine("Деление на ноль запрещено");
                        else
                            Console.WriteLine("Answer" + (n1 / n2));
                        break;
                    default:
                        Console.WriteLine("Непонятный знак");
                        break;
                }
            }
           
        }
    }
}
