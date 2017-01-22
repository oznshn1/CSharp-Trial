using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpDenemeleri
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Enter a number..: "); // Write i, i*i, i*i*i from 1 to entered number
            int number;
            if (Int32.TryParse(Console.ReadLine(), out number))
            {
                int i=1;
                while (i <= number)
                {
                    Console.WriteLine("{0} {1} {2}",i,i*i,i*i*i);
                    i++;
                }
                //Console.ReadKey();
            }
            else
                Console.WriteLine("You must enter a number..!");

            Console.WriteLine("____________________________________________________");

            Console.WriteLine("Enter square's one length..:"); // draw a square for entered length
            int length;
            if (Int32.TryParse(Console.ReadLine(), out length)) 
            {
                int j = 1;
                while (j <= length)
                {
                    int k = 0;
                    while (k < length)
                    {
                        Console.Write("* ");
                        k++;
                    }
                    Console.Write("\n");
                    j++;
                }
                //Console.ReadKey();
            }

            Console.WriteLine("____________________________________________________");

            Console.Write("Enter triangle's length..: "); // draw a triangle for entered length
            int length2;
            if (int.TryParse(Console.ReadLine(), out length2))
            {
                int j = 1;
                while (j <= length2)
                {
                    int k = 0;
                    while (k < j)
                    {
                        Console.Write("* ");
                        k++;
                    }
                    Console.WriteLine();
                    j++;
                }
                //Console.ReadKey();
            }
            else
                Console.WriteLine("You must enter a numeric value..!");

            Console.WriteLine("____________________________________________________");

            Console.Write("Enter a number..: "); // Find sum of odd numbers from 1 to entered number
            int number2;
            if (int.TryParse(Console.ReadLine(), out number2))
            {
                FindOddNumbers odd = new FindOddNumbers();
                int sum = odd.findOddNumbers(number2);
                Console.WriteLine();
                Console.WriteLine("sum of odd number from 1 to {0} ..: {1}", number2, sum);
            }
            else
                Console.WriteLine("You must enter a numeric value..!");
            //Console.ReadKey();

            Console.WriteLine("____________________________________________________");

            Console.Write("Enter a number..: "); // Factorial Calculating
            int number3;
            if (int.TryParse(Console.ReadLine(), out number3))
            {
                Factorial f = new Factorial();
                int sum = f.CalculateFactorial(number3);
                Console.WriteLine("{0}! = {1}", number3, sum);
            }
            else
                Console.WriteLine("You must enter a numeric value..!");
            //Console.ReadKey();
            Console.WriteLine();
        }
    }
}
