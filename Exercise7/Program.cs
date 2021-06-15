using System;

namespace Exercise7
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = 0;
            Console.WriteLine("Please enter number:");
            number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Rounded calue of {0} is {1}", number, (int) (number + 0.5));
            Console.ReadKey();
        }
    }
}
