using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace check1
{
    class Program
    {
        static void Main(string[] args)
        {
            int input;
            List<int> numbersInputOdd = new List<int>();
            List<int> numbersInputEven = new List<int>();

            Console.Write("Enter a Number : ");
            input = int.Parse(Console.ReadLine());

            if (input > 0)
            {
                for (int j = 0; j <= input; j++)
                {
                    if (j % 2 != 0)
                    {
                        Console.WriteLine(j);
                        numbersInputOdd.Add(j);
                    }
                    else
                    {
                        numbersInputEven.Add(j);
                    }
                }
            }
            else if (input <= 0)
            {
                Console.WriteLine("ERROR: {0} is not a valid integer.", input);
            }
            Console.ReadLine();

        }
    }
}
