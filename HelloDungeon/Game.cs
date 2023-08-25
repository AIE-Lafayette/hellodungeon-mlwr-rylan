using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        public void Run()
        {
            //create and initialize variables
            int areaNumber = 0;
            bool playerIsAlive = true;
            float health = 100.0f * 2;
            float shield = 0f;
            String playerName = "Rylan Babers";
            string playerChoice = Console.ReadLine();
            bool hasSmoke = true;
            
            //get character name
            Console.WriteLine("Rylan");
            Console.WriteLine("Babers");

            //get the entered name
            string firstName = Console.ReadLine();
            string lastName = Console.ReadLine();
            playerName = firstName + lastName;

            //Display name to be said again
            Console.WriteLine(playerName);

            //decision starter
            Console.WriteLine("Old dirty man approaches you on your journey.");
            Console.WriteLine("He offers you a stinky brown smoke.");
            Console.WriteLine("You notice upon closer observation its a viscus substance.");

            Console.WriteLine("If you take a whiff of this you'll feel");
            Console.WriteLine("more geeked than ever");

            Console.WriteLine("Do you ingest the substance?");

            //Display Choices
            Console.WriteLine("1. Yes");
            Console.WriteLine("2. No");
            Console.WriteLine("3. Run off with the sack.");

            //take players input.
            playerChoice = Console.ReadLine();

            //the results of my decisions.
            if (playerChoice == "1")
            {
                Console.WriteLine("The smoke is super smooth and taste delightful.");
                Console.WriteLine("You begin to laugh and see things funny. You gain 50 shield.");

                shield += 50;
            }
            if (playerChoice == "2")
            {
                Console.WriteLine("You decline the smoke.");
                Console.WriteLine("Old man gets mad and attacks.");
                Console.WriteLine("You lose 2 health. He is weak.");

                health -= 2;
                Console.WriteLine("health is now 98.");
            }
            if (playerChoice == "3");
            {
                Console.WriteLine("You reach for the old man's sack");
                Console.WriteLine("You take it and successfully run off.");

                pockets += 1;
            }
            { 
            }
        }
    }
}
