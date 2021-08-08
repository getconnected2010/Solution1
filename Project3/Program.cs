using System;
using System.Threading;
using System.Threading.Tasks;

namespace Project3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Thread t1 = new Thread(new ThreadStart(firstThread));
            //Thread t2 = new Thread(new ThreadStart(secondThread));
            //Task t1 = new Task(firstThread);
            //Task t2 = new Task(secondThread);

            //t1.Start();
            //t2.Start();

            firstThread();
            secondThread();
            Console.WriteLine("Hello World!");
        }

        static async void firstThread()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(2000);
                Console.WriteLine("First Thread " + i);
            }
        }

        static async void secondThread()
        {
            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(2000);
                Console.WriteLine("Second Thread " + i);
            }
        }
    }
}
