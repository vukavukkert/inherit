using System;
using System.Collections.Generic;
using System.Text;

namespace inherit
{
    class Horse: Animal
    {
        public Horse(int satiety = 20, int energy = 20)
            : base("Horse", "Neigh", satiety, energy)
        {
        }
    }
}
