using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB_0_OOPS2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a low number: ");
            int lownum = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a high number: ");
            int highnum = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("The difference of these numbers is " + (highnum - lownum));

            int[] numbers = new int[highnum - lownum + 1];

            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = lownum + i;
            }
            using (StreamWriter writer = new StreamWriter("numbers.txt"))
            {
                for (int i = numbers.Length - 1; i >= 0; i--)
                {
                    writer.WriteLine(numbers[i]);
                }
            }

            Console.WriteLine("Numbers are written to the numbers.txt");
            Console.ReadKey();
        }
    }
}
