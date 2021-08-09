using System;
using System.Collections.Generic;
using System.Text;
using static System.Console;

namespace VirtualPetSimulator
{
    class VirtualPet
    {
        public string name { get; private set; }
        public int id { get;}
        public string nameId {
            get => $"{name} {id}";
        }
        private int _age;
        public int age {
            get 
            {
                WriteLine("someone is reading age property");
                return _age;
            }
            set
            {
                if (value < 0)
                {
                    WriteLine("age can't be below zero");
                    value = 0;
                }
                _age = value;
            }
        }  

        public VirtualPet(String petName)
        {
            name = petName;
            id = 001;
            age = 0;
        }
    }
}
