using System;
using static System.Console;

namespace VirtualPetSimulator
{
    class Program
    {
        static void Main(string[] args)
        {
            World myWorld;
            for (int i = 0; i < 8; i++)
            {
                myWorld = new World($"Nala{i}");
            }
            World.petList();
            World.insertPet(2, "Leo");
            WriteLine("============");
            World.petList();
        }
    }
}
