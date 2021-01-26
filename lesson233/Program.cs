using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lesson23
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = int.Parse(Console.ReadLine());
            int diapozon = int.Parse(Console.ReadLine());
            int even = 0;
            int noEven = 0;

            while (count < diapozon)
            {
                if (count % 2 == 0)
                {
                    even += count;
                }
                else
                {
                    noEven += count;
                }
                count++;
            }

            Console.WriteLine("Sum Even" + even);
            Console.WriteLine("Sum No even" + noEven);
            Console.ReadKey();
        }
    }
}
