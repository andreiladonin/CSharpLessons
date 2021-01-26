using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myfirstProject
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.ReadKey();
        }

        static void average ()
        {
            double n1 = Convert.ToDouble(Console.ReadLine());
            double n2 = Convert.ToDouble(Console.ReadLine());
            double average = (n1 + n2) / 2;
            Console.WriteLine("Average = " + average);
        }

        static void sum_and_composition()
        {
            List<double> number = new List<double>();
            double sum = 0;
            double cmposition = 1;
            for (int i = 0; i < 3; i++)
            {
                double n = Convert.ToDouble(Console.ReadLine());
                number.Add(n);
            }

            for (int i = 0; i < number.Count; i++)
            {
                sum += number[i];
                cmposition *= number[i];
            }

            Console.WriteLine("Сумма " + sum);
            Console.WriteLine("Произведение " + cmposition);
        }

        static void convetr()
        {
            const decimal RUB = 75.41M;
            decimal dollar = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine(dollar + "$ = " + (RUB * dollar) + "RUB");
        }

    }
}
