using System;

namespace inherit
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = Console.ReadLine();
            Animal newAnimal = Controller.CreateAnimal(type);
            Food food = new Meat();
            newAnimal.Feed(food);
        }
    }
}
