using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson16
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());

            if (count % 2 == 0)
            {
                Console.WriteLine("Четное");

            }
            else
            {
                Console.WriteLine("Не четное");
            }

            Console.ReadKey();
        }
    }
}
