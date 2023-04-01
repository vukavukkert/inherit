using System;
using System.Collections.Generic;
using System.Text;

namespace inherit
{
    class Grass : Food
    {
        public Grass(string type, int saturation = 1)
           : base("Grass", saturation)
        {
            Type = type;
        }
    }
}
