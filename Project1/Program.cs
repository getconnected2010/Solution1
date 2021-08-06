using System;
using ClassLibrary1;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            Calc x = new Calc();
            x.greet();
            Console.WriteLine(x.add(2, 6));
        }
    }
}
