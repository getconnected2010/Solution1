using System;
using ClassLibrary1;

namespace Project2
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;
            double db = 2.0;
            counter = (int) db; //explicit casting into an int
            string a = "145";
            counter = Convert.ToInt32(a);
            counter++;
            for(int i=0; i<10; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine(counter);
            Class1 x = new Class1();
            Console.WriteLine("Hello World 2 !"+ x.getDateTime());
        }
    }
}
