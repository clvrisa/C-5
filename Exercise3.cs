using System;
namespace C5
{
    class Exercise3
    {
        static void f(string s)
        {
            s += "world";
        }
        [STAThread]
        static void Main(string[] args)
        {
            string s = "Hello";
            f(s);
            Console.WriteLine(s);
        }
    }
}
