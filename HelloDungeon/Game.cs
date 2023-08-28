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
        public void Run()
        {


            //create and initialize variables
            int areaNumber = 0;
            bool gamePlay = true;
            float health = 100.0f * 2;
            float shield = 0f;
            string playerName;
            string playerChoice = "";
            bool hasSmoke = false;

            //while (gamePlay == true)
            //{
                //get character name
                Console.WriteLine("WELCOME! WHATS YOUR NAME?");


                //get the entered name
                string firstName = Console.ReadLine();
                string lastName = Console.ReadLine();
                playerName = firstName + lastName;

                //Display name to be said again
                Console.Write("Are you ready " + playerName + " ?");
                Console.ReadKey(true);
                Console.ReadLine();
                Console.Clear();
                //decision starter
                Console.WriteLine("Youre randomly approached by a dirty guy...");
                Console.ReadLine();
                Console.WriteLine("He offers you to try some stinky smoke.");
                Console.ReadLine();


                Console.WriteLine("If you take a whiff of this you'll feel");
                Console.WriteLine("more geeked than ever");
                Console.Clear();
               
            while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
            {

                //Display Choices 
                Console.WriteLine("Do you ingest the substance?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.WriteLine("3. Run off with the sack.");
                playerChoice = Console.ReadLine();                                                  //take players input.
                Console.WriteLine("Invalid Choice"); 
                
                Console.ReadKey(true);  
                Console.Clear();

            }
                //the results of my decisions.
                if (playerChoice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("The smoke is super smooth and taste delightful.");
                    Console.WriteLine("                                               ");
                Console.ReadLine();
                    Console.WriteLine("You begin to laugh and see things funny. You gain 50 shield.");

                    shield += 50;
                }
                else if (playerChoice == "2")                           //no smoke
                {
                    Console.WriteLine("You decline the smoke.");
                    Console.Clear();
                    Console.WriteLine("Old man gets mad and attacks.");             //reason for gasping om
                    Console.ReadLine();
                    Console.WriteLine("You lose 2 health. He is weak.");
                    health -= 2;
                    Console.WriteLine("Health is now 98.");
                }
                else if (playerChoice == "3")
                {                                                                   //run off
                    Console.WriteLine("You reach for the old man's sack");
                    Console.Write("You take it and successfully run off.");
                    Console.WriteLine("+1 Smoke");
                    hasSmoke = true;
                }


                
                Console.WriteLine("Press any Key to Continue");
                Console.ReadKey(true);

                Console.Clear();
                if(playerChoice == "2")                                                 //after hurt old man
                {                                                                     // only from 2
                    //after you react
                    Console.WriteLine("Congrats!!! You made it past old man.");
                    Console.ReadKey(true);
                    Console.WriteLine("He is now on the ground gasping for breath.");

                    Console.ReadLine();
                    Console.WriteLine("What do you do now?");
                    Console.ReadLine();


                    Console.WriteLine("1. Continue past his unconcious body.");                //new list choices
                    Console.WriteLine("2. Search his pockets.");
                    Console.WriteLine("3. Finish the job.");

                    //second choice input
                    playerChoice = Console.ReadLine();

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
                    Console.WriteLine("2. Search his pockets.");                              //list #3
                    Console.WriteLine("3. Finish the job.");

                     if (playerChoice == "2")
                    {
                     Console.Clear();
                     Console.WriteLine("You run the old mans pockets and find:");
                     Console.WriteLine("- Bag of Smoke");
                     Console.WriteLine("- Revolver");                                       //pockets list
                     Console.WriteLine("- Pecan Pie");
                     Console.WriteLine("- Stack of Cash");






                     }
                
                }   
            //}
        }
    }

