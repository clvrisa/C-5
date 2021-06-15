using System;
using System.Collections.Generic;
using System.Linq;
using.System.text;


namespace C5
{
    class Square
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter a number =>");
            int a = Convert.ToInt32(Console.ReadLine());
            if(a>0 && a<=10)
            {
                a = a << 1;
                Console.Write("{0},", a);
            }
            Console.ReadKey();
        }
    }
}
