using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace VirtualPetSimulator
{
    class World
    {
        public static List<VirtualPet> petWorld = new List<VirtualPet>();

        public World(String name)
        {
            petWorld.Add(new VirtualPet(name));
        }
        public static void petList()
        {
            foreach (var item in World.petWorld)
            {
                WriteLine(item.name);
            }
        }
        public static void insertPet(int x, String name)
        {
            petWorld.Insert(x, new VirtualPet(name));
        }
    }
}
