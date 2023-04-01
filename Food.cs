using System;
using System.Collections.Generic;
using System.Text;

namespace inherit
{
    class Food
    {
        public int Saturation { get; set; }
        protected string Type { get; set; }
        public Food(string type = "Undinified", int saturation = 2)
        {
            Type = type;
            Saturation = saturation;
        }

        public int Eat()
        {
            return Saturation;
        }
    }
}
