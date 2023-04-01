using System;
using System.Collections.Generic;
using System.Text;

namespace inherit
{
    class Animal
    {
        Food food = new Food();
        protected string Type { get; set; }
        protected string Name { get; set; }
        protected string Sound { get; }
        protected int Satiety { get; set; }
        protected int Energy { get; set; }

        public Animal(string type = "Undinified", string sound = "Undinified", int satiety = 10, int energy = 10)
        {
            Type = type;
            Sound = sound;
            Satiety = satiety;
            Energy = energy;
        }
        public void Voice()
        {
            Console.WriteLine(Sound);
        }
        public void Feed(Food food)
        {
            Satiety += food.Eat();
            Console.WriteLine(Satiety + " сытости");
        }
        public void Sleep()
        {
            Energy += 2;
            Console.WriteLine(Energy + " энергии");
        }
    }
}
