using System;
using System.Collections;
using System.Collections.Generic;
using ClassLibrary1;

namespace Project1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arrInt = new int[13];
            string[] arrStr = new string[2];
            arrInt[0] = 4;
            arrStr[0] = "eden";

            ArrayList arrList = new ArrayList();
            arrList.Add(2);
            arrList.Add("eden");

            List<int> genIntList = new List<int>();
            genIntList.Add(1);
            genIntList.Add(5);

            List<string> genStrList = new List<string>();
            genStrList.Add("eden");
            genStrList.Add("daddy");
            genStrList.Add("mommy");
            genStrList.Add("grandma");
            genStrList.Add("mahlet");

            foreach(string item in genStrList)
            {

                Console.WriteLine(item);
            }
            //write to the console
            Console.WriteLine("eden");
            //read from the console
            int num1 = Convert.ToInt32(Console.ReadLine());
            int num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                int result = num1 / num2;
            }
            catch (Exception e)
            {

                Console.WriteLine("error found");
            }
            
            Calc x = new Calc();
            x.greet();
            Console.WriteLine(x.add(2, 6));
        }
    }
}
