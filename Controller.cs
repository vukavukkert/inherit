using System;
using System.Collections.Generic;
using System.Text;

namespace inherit
{
    class Controller
    {
        static public Animal CreateAnimal(string type)
        {

            switch (type)
            {
                case "cat":
                    return new Cat();
                case "dog":
                    return new Dog();
                case "horse":
                    return new Horse();
                default:
                    throw new ArgumentException($"Invalid animal type: {type}");
            }
        }
        static public Food CreateFood(string type)
        {

            switch (type)
            {
                case "meat":
                    return new Meat();
                case "fish":
                    return new Fish();
                case "grass":
                    return new Grass();
                default:
                    throw new ArgumentException($"Invalid animal type: {type}");
            }
        }
        public void FeedAnimal(Animal animal, Food food)
        {
            animal.Feed(food);
        }
        public void AnimalSleep(Animal animal)
        {
            animal.Sleep();
        }
        public void AnimalVoice(Animal animal)
        {
            animal.Voice();
        }

    }
}
