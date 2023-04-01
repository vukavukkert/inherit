using System;
using System.Collections.Generic;
using System.Text;

namespace inherit
{
    class Meat : Food
    {
        public Meat(string type = "Meat", int saturation = 5)
            :base("Meat", saturation)
        {
            type = Type;
        }
    }
}
