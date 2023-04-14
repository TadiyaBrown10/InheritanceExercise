using System;

namespace Inheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO Be sure to follow best practice when creating your classes

            // DONECreate a class Animal
            // DONE give this class 4 members that all Animals have in common


            // DONE Create a class Bird
            // DONE give this class 4 members that are specific to Bird
            // DONE Set this class to inherit from your Animal Class

            // DONE Create a class Reptile
            // DONE give this class 4 members that are specific to Reptile
            // DONE Set this class to inherit from your Animal Class




            /*Create an object of your Bird class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */
            var theBird = new Bird();

            theBird.canFly = true;
            theBird.Color = "White & Black";
            theBird.Food = "Seeds & Worms";
            theBird.hasFeathers = true;
            theBird.haslegs = 2;
            theBird.HasTail = true;
            theBird.Name = "Woodpecker";
            theBird.EyeColor = "black";

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Reptile class
             *  
             * Creatively display the class member values 
             */

            var crawlers = new Reptile();

            crawlers.Name = "Turtle";
            crawlers.LiveInWater = true;
            crawlers.LikeHeat = true;
            crawlers.HasTail = true;
            crawlers.haslegs = 4;
            crawlers.EatMeat = false;
            crawlers.Color = "Green ";
            crawlers.SkinTexture = "Rough and bumpy";

            var myAnimals = new Animal[2] { theBird, crawlers};

            foreach(var animals in myAnimals)
            {
                Console.WriteLine($"Its color is {animals.Color} ");
                Console.WriteLine($"Is it true that it has a tail? {animals.HasTail}");
                Console.WriteLine($"What is it's name? {animals.Name}");
                Console.WriteLine($"How many legs does it have? {animals.haslegs}");
                Console.WriteLine("");
            }
        }
    }
}
