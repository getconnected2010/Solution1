using System;

namespace ClassLibrary1
{
    public class Class1
    {
        public string getDateTime()
        {
            return DateTime.Now.ToString();
        }
    }
    public class Calc
    {
        public string name = "eden";

        public int add(int a, int b)
        {
            return a + b;
        }
        public int div(int a, int b)
        {
            return a / b;
        }
        public void greet()
        {
            Console.WriteLine("Hello from greet.");
        }
    }
}
