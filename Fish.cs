using System;
using System.Collections.Generic;
using System.Text;

namespace inherit
{
    class Fish : Food
    {
        public Fish(string type, int saturation = 2)
           : base("Fish", saturation)
        {
            Type = type;
        }
    }
}
