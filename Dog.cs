using System;
using System.Collections.Generic;
using System.Text;

namespace inherit
{
    class Dog : Animal
    {
        public Dog(int satiety = 15, int energy = 15)
            : base("Dog", "Bark", satiety, energy)
        {

        }
    }
}
