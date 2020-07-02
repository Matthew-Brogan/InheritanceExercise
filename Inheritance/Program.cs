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
             *  
             * Creatively display the class member values 
             */

            /*Create an object of your Reptile class
             *  give values to your members using the object of your Bird class
             *  
             * Creatively display the class member values 
             */

            Bird Owl = new Bird();
            Owl.Legs = 2;
            Owl.Predatory = true;
            Owl.Name = "Barn Owl";
            Owl.Size = "pretty big";
            Owl.Wingspan = 230;
            Owl.Flightless = false;
            Owl.Domesticated = false;
            Owl.Eats = "small rodents";

            Console.WriteLine($"I'd love to tell you about my favorite bird! Its a {Owl.Name}! They arent the biggest of the owls but they are {Owl.Size}, their general wingspan is about {Owl.Wingspan}cm." +
                $"They usually eat {Owl.Eats}, and dont mistake these things for penguins because assuming they are flighless would be {Owl.Domesticated}," +
                $" however, to assume that they are predatory would be {Owl.Predatory}. And is most cases we can generally say that a barn owl being Domesticated is {Owl.Domesticated}." +
                $"Another interesting thing about owls is that they have {Owl.Legs} legs, that are suprisingly long!");

            Reptile gecko = new Reptile();
            gecko.RepCon(4, "insects", "leopard gecko", true, true, true, false, 110);
            Console.WriteLine($"Now, on to my favorite reptile! The {gecko.Name}, these interesting little guys cant just save you a ton on your car insurance! " +
                $"Did you know that they have {gecko.Legs} legs, and a tail which can all regrow if lost to a predator or injury!  " +
                $"It is {gecko.MoltsToGrow} that geckos do occasionally shed their skin, and it is also {gecko.Domesticated} that geckos are domesticated! " +
                $"Though if you are afraid of bugs you may want to steer clear as the main diet of a gecko consists of {gecko.Eats}, and incredibly these little guys have {gecko.Teeth} teeth!" +
                $"Its also {gecko.Amphibious} that these little guys can live and breathe in water for a time, while for most species it is {gecko.Poisonous} that they are poisonous");

            

        }
    }
}
