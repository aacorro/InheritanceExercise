using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // Create a class Animal
            // give this class 4 members that all Animals have in common


            // Create a class Bird
            // give this class 4 members that are specific to Bird
            // Set this class to inherit from your Animal Class

            // Create a class Reptile
            // give this class 4 members that are specific to Reptile
            // Set this class to inherit from your Animal Class



            
            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             * 
             * Creatively display the class member values 
             */


            Bird falcon = new Bird();
            falcon.beakShape = "raptorial";
            falcon.nesting = "scrapes";
            falcon.numSpecies = 19;
            falcon.migration = true;


            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             * 
             * 
             */

            Reptile turtle = new Reptile();
            turtle.numSpecies = 356;
            turtle.reproduction = "eggs";
            turtle.isDangerous = false;
            turtle.canRegenerate = false;


            var animalInventory = new Animal[] { falcon, turtle };

            foreach (var item in animalInventory)
            {
                Console.WriteLine(item.GetType().Name);
                Console.WriteLine($"Can swing: {item.canSwing}");
                Console.WriteLine($"Animal group: {item.groupOrClass}");
                Console.WriteLine($"Can Fly: {item.canFly}");
                Console.WriteLine($"Fertilization: {item.fertilization}");
                Console.WriteLine();
               
            }
            
        }
    }
}
