using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Numerics;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Security.Authentication;
using System.Text;
using System.Threading.Tasks;

namespace HelloDungeon
{
    class Game
    {
        int areaNumber = 0;
        bool gamePlay = true;
        float health = 100.0f;
        float shield = 0f;
        string playerName;
        float playerDamage = 20f;
        string playerChoice = "";


        void IncreaseShield(float amount)
        {
            shield += amount;

        }

        void PrintStats(string playerName, float health, float damage, float shield)
        {
            Console.WriteLine("Name: " + playerName);
            Console.WriteLine("Health: " + health);
            Console.WriteLine("Damage: " + damage);
            Console.WriteLine("Shield: " + shield);
        }
        void PrintStatistics(float health)
        {
            Console.WriteLine("Health: " + health);
        }
        void PrintSStats(float shield)
        {
            Console.WriteLine("Shield: " + shield);
        }
        //menu funk

        void DisplayMainMenu()
        {//MAIN MENU
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
        }
        void DisplayScene1()
        {
            Console.WriteLine("Youre approached by a dirty old man...");
            Console.ReadLine();
            Console.WriteLine("He offers you to try some stinky liquid.");
            Console.ReadKey(true);

            Console.Clear();
            Console.WriteLine("If you take a sip of this you'll feel");
            Console.WriteLine("more powerful than ever!!!");
            Console.ReadLine();
            Console.Clear();

            while (playerChoice != "1" && playerChoice != "2" && playerChoice != "3")
            {
                //Display Choices 
                Console.WriteLine("Do you ingest the substance?");
                Console.WriteLine("1. Yes");
                Console.WriteLine("2. No");
                Console.WriteLine("3. Run off with the drink.");
                playerChoice = Console.ReadLine();                                                  //take players input.

                if (playerChoice == "1")
                {
                    Console.Clear();
                    Console.WriteLine("The drink is super smooth and taste delightful.");
                    Console.WriteLine("You gain 50 shield.");

                    IncreaseShield(50f);
                    PrintSStats(shield);



                }
                else if (playerChoice == "2")
                {

                    Console.WriteLine("You decline the drink.");

                    Console.WriteLine("Old man gets mad and attacks.");
                    Console.WriteLine("You lose 2 health. He is weak.");
                    PrintStatistics(health);
                }
                else if (playerChoice == "3")
                {                                                                   //run off
                    Console.WriteLine("You reach for the old man's drink");
                    Console.Write("You take it and successfully run off.");
                    Console.WriteLine("+1 Drink");

                }
                else
                {
                    Console.WriteLine("Not an Answer.");
                }



            }
            Console.ReadKey();
        }



        void DisplayScene2()
        {
            Console.Clear();
            Console.WriteLine("What do you do now?");
            Console.ReadLine();
            Console.WriteLine("1.Continue Journey");

            playerChoice = Console.ReadLine();



        }

      
        public void Run()
        {

             
             
                DisplayMainMenu();

                DisplayScene1();

                DisplayScene2();
                Console.Clear();







                 if (playerChoice == "2")
                 { 
                    Console.WriteLine("OUCH!!! What do you do back?");
                    Console.ReadKey(true);
                    Console.ReadLine();
                    Console.Clear();


                    
                    

                 }

                    Console.WriteLine("1.Hit him back!");
                    Console.WriteLine("2.Run");
                    


             

        }
    } 
} 




   
    
        

        
    
   
    
//PrintStats(playerName, playerHealth, playerDamage)