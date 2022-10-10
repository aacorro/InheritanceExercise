using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
  

            Bird falcon = new Bird();
            falcon.beakShape = "raptorial";
            falcon.nesting = "scrapes";
            falcon.numSpecies = 19;
            falcon.migration = true;


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
