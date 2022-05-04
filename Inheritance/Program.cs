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

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            Bird puffin = new Bird()

            {
                Name = "Puffin",
                Age = 36,
                Legs = 2,
                HasBackbone = true,
                IsWarmBlooded = true,
                HasFeather = true,
                Type = "fying and water",
                Wings = 2,
            
            
            
            
            };

            Console.WriteLine($"{puffin.Name} is the penguin of the north the old one we know of is {puffin.Age} years old ");
            Console.WriteLine($"{puffin.Name} has a back bone {puffin.HasBackbone} also they have feather {puffin.HasFeather}. A {puffin.Name} is warm boolded they also " +
                $"{puffin.Legs} legs and {puffin.Wings} wings");


            Reptile wyvern = new Reptile()
            {
                Name = "wyvern",
                Age = 9000,
                HasBackbone = true,
                IsColdBlooded = true,
                HasScales = true,
                Environmet = "extreme",
                Defense = "breath weapons, teeth, and claws"

                




            };

            Console.WriteLine($"{wyvern.Name} is an ancient creature that could live up to {wyvern.Age} that could kill with its {wyvern.Defense}");
            Console.WriteLine($"they where cold blooded killers {wyvern.IsColdBlooded} they had the srongest back bone around {wyvern.HasBackbone}");
            Console.WriteLine($"to with stand the {wyvern.Environmet} they had super strong scales {wyvern.HasScales}");






        }
    }
}
