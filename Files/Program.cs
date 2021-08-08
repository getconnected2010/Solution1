using System;
using System.IO;

namespace Files
{
    enum CustomErrors
    {
        FileNotFound = 1003,
        AccessDenied = 1993,
        Unkown = 2889
    }
    class Program
    {
        static void Main(string[] args)
        {
            //File.WriteAllText(@"C:\Users\haile\OneDrive\Documents\projects\C#\data.txt", "Hello world");
            //string fileInput = File.ReadAllText(@"C:\Users\haile\OneDrive\Documents\projects\C#\data.txt");
            //Console.WriteLine(fileInput);

            CustomErrors x = (CustomErrors) Convert.ToInt32(Console.ReadLine());
            if(x == CustomErrors.Unkown)
            {
                Console.WriteLine("Unknw");
            }
        }
    }
}
