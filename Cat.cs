using System;
using System.Collections.Generic;
using System.Text;
using inherit;

namespace inherit
{
    class Cat : Animal
    {
        public Cat(int satiety = 10, int energy = 10)
            :base("Cat","Meow", satiety, energy)
        {
           
        }
    }
}
