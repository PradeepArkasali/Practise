using System;

namespace FactoryMethodPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             * GOF Defination - Define a Interface for creating a object, but let subclasses decide which class need to be instatiated.
             * The Factory Method Pattern lets a class differ a instantiation to subclass
             */

            Console.WriteLine("***Factory Pattern Demo***\n");
            // Creating a Tiger Factory
            IAnimalFactory tigerFactory = new TigerFactory();
            // Creating a tiger using the Factory Method
            IAnimal aTiger = tigerFactory.CreateAnimal();
            aTiger.Speak();
            aTiger.Action();
            // Creating a DogFactory
            IAnimalFactory dogFactory = new DogFactory();
            // Creating a dog using the Factory Method
            IAnimal aDog = dogFactory.CreateAnimal();
            aDog.Speak();
            aDog.Action();
            Console.ReadKey();
        }
    }
}
