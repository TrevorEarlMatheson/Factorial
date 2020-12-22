using System;

namespace Factorial
{
    class Program
    {
        static int Factorial(int number)
        {
            int stop = 1;
            if(number > stop)
            {
                number *= Factorial(--number);
            }
            return(number);
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number you want to know the factorial of.");
            var entry = Console.ReadLine();
            Console.WriteLine("{0}! = {1}", entry, Factorial(int.Parse(entry)));
        }
    }
}
