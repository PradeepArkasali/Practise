using System;

namespace FactoryMethodPattern
{
    public class Dog : IAnimal
    {
        public void Action()
        {
            Console.WriteLine("Dogs prefer barking...\n");
        }

        public void Speak()
        {
            Console.WriteLine("Dog says: Bow-Wow");
        }
    }
}
