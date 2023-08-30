using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        //float Add(float a, float b)
        //{
        //    float result = a + b; 
        //    return result;
        //}
        //how to count from
        //void CountInBetween(int a, int b)
        //{
        //    for (int i = a; i <= b; i++)
        //      (a % 2 == 0)
        //    {
        //        Console.WriteLine(i);

        //    }
        //} 



        void PrintStats(string playerName, float health, float damage, float shield)
        {
            Console.WriteLine("Name: " + playerName);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine("Shield: " + shield);
        }

        //menu funk
        string DisplayMenu(string prompt, string option1, string option2, string option3)
        {
            string playerChoice = "";

            while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3") ;
            {
                Console.WriteLine(prompt);
                Console.WriteLine("1. " + option1);
                Console.WriteLine("2. " + option2);
                if (option3 != "3")
                {
                    Console.WriteLine("3. " + option3);
                }

                Console.Write(">");
                playerChoice = Console.ReadLine();

                while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3") ;
                {
                    Console.WriteLine(prompt);
                    Console.WriteLine("1. " + option1);
                    Console.WriteLine("2. " + option2);
                    if (option3 != "3")
                    {
                        Console.WriteLine("3. " + option3);
                    }

                    Console.Write(">");
                    playerChoice = Console.ReadLine();
                }
                Console.WriteLine("MMMM, try again.");
            }
            return "";
        }     
       
             


        public void Run()
        {
            //   float sum = Add(4f, 8.25f);
            //Console.WriteLine(sum);
            //    return;

            //create and initialize variables
            int areaNumber = 0;
            bool gamePlay = true;
            float health = 100.0f;
            bool battleStarted = false;
            float shield = 0f;
            string playerName;
            float playerDamage = 20f;
            string playerChoice = "";
            bool hasSmoke = false;

            while (gamePlay == true)
            {
                if(gamePlay = false)
                //get character name
                Console.WriteLine("WELCOME! WHATS YOUR NAME?");


                //get the entered name
                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();
                playerName = firstName + lastName;

                //Display name to be said again
                Console.WriteLine("Are you ready " + playerName + " ?  >enter<");
                Console.ReadKey(true);
                PrintStats(playerName, health, playerDamage, shield);
                Console.ReadLine();
                Console.Clear();
                //Console.ReadLine();
                //decision starter
                Console.WriteLine("Youre approached by a dirty old man...");
                Console.ReadLine();
                Console.WriteLine("He offers you to try some stinky liquid.");
                Console.ReadKey(true);

                Console.Clear();
                Console.WriteLine("If you take a sip of this you'll feel");
                Console.WriteLine("more powerful than ever!!!");
                Console.ReadLine();
                Console.Clear();

                //-----------------------------------------------------------
                Console.WriteLine("Do you ingest the substance?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.WriteLine("3. Run off with the drink.");
                playerChoice = Console.ReadLine();
                while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
                {
                    Console.WriteLine("Invalid Choice");
                    Console.ReadKey(true);
                    Console.Clear();
                    //Display Choices 
                    Console.WriteLine("Do you ingest the substance?");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    Console.WriteLine("3. Run off with the drink.");
                    playerChoice = Console.ReadLine();                                                  //take players input.


                    Console.ReadKey(true);
                    Console.Clear();

                }
                //the results of my decisions.
                if (playerChoice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("The drink is super smooth and taste delightful.");
                    Console.WriteLine("                                               ");
                    Console.ReadLine();
                    Console.WriteLine("You gain 50 shield.");

                    shield += 50;
                }
                else if (playerChoice == "2")                           //no smoke
                {
                    Console.WriteLine("You decline the drink.");
                    Console.Clear();
                    Console.WriteLine("Old man gets mad and attacks.");             //reason for gasping om
                    Console.ReadLine();
                    Console.WriteLine("You lose 2 health. He is weak.");
                    health -= 2;
                    Console.WriteLine("Health is now 98.");
                }
                else if (playerChoice == "3")
                {                                                                   //run off
                    Console.WriteLine("You reach for the old man's drink");
                    Console.Write("You take it and successfully run off.");
                    Console.WriteLine("+1 Drink");
                    hasSmoke = true;
                }


                Console.WriteLine("                         ");
                Console.WriteLine("Press any Key to Continue");
                Console.ReadKey(true);

                Console.Clear();
                if (playerChoice == "2")                                                 //after hurt old man
                {                                                                     // only from 2
                                                                                      //after you react
                    Console.WriteLine("OUCH!!! What do you do back?");
                    Console.ReadKey(true);
                    Console.ReadLine();
                    Console.Clear();


                    Console.WriteLine("1.Hit him back!");
                    Console.WriteLine("");

                    while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
                    {
                        Console.WriteLine("1. Continue past his unconcious body.");                //new list choices
                        Console.WriteLine("2. Search his pockets.");
                        Console.WriteLine("3. Finish the job.");

                        //second choice input
                        playerChoice = Console.ReadLine();
                    }
                }
                if (playerChoice == "1")
                {
                    Console.WriteLine("You walk past the old dead man.");
                    Console.ReadLine();
                    Console.WriteLine("He grabs you by the leg!!!");

                    Console.ReadLine();
                    Console.Clear();                                                                //stomp event
                    Console.WriteLine("PRESS H TO STOMP HIM");
                    Console.ReadKey(true);
                    Console.Clear();
                    Console.WriteLine("You killed the old man.");
                    Console.ReadLine();
                    Console.WriteLine("What do you do now?");
                }
                while (playerChoice != "2" && playerChoice != "3")
                {
                    Console.WriteLine("2. Search his pockets.");                              //list #3
                    Console.WriteLine("3. Finish the job.");
                    playerChoice = Console.ReadLine();

                    if (playerChoice != "2" && playerChoice != "3")
                    {
                        Console.WriteLine("Not an Answer.");
                    }
                }

                    if (playerChoice == "2")
                    {
                        Console.Clear();
                        Console.WriteLine("You run the old mans pockets and find:");
                        Console.WriteLine("- Bag of Smoke");
                        Console.WriteLine("- Revolver");                                       //pockets list
                        Console.WriteLine("- Pecan Pie");
                        Console.WriteLine("- Stack of Cash");



                        while (playerChoice != "1" && playerChoice != "2")
                        {
                            Console.WriteLine("Game Over! Play Again");
                            Console.WriteLine("1. Play Again");
                            Console.WriteLine("2. Exit");
                            playerChoice = Console.ReadLine();

                            if (playerChoice == "2")
                            {
                                gamePlay = false;
                            }
                            else if (playerChoice != "1")
                            {
                                Console.WriteLine("Yo Whats Wrong With You");
                            }

                           
                        }
                    }

                
            }

        }
    }
}    
    
//PrintStats(playerName, playerHealth, playerDamage)