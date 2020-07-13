using System;
using System.Collections.Generic;
using System.Linq;

namespace Cee_Lo_Saloon
{
    class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("~~Cee-Lo Saloon~~ \npress ENTER to enter the saloon");
            Console.ReadLine();
            Console.WriteLine("Well howdy, potnah! My name's Wild West Willie. :D \nWelcome to The Cee-Lo Saloon. Lets play some Cee-Lo. Do you know how to play, champ?(y/n)");
            string knowHowToPlay = Console.ReadLine();

            while (knowHowToPlay != "n" && knowHowToPlay != "y")
            {
                Console.WriteLine("I say, I say, you know how to play or DON'T ya?!(y/n)");
                knowHowToPlay = Console.ReadLine();
            }

            if (knowHowToPlay == "n")
            {
                Console.WriteLine("Alright buddy, here are the rules: \nCee-Lo (aka 4-5-6) \n" +
                    "Roll 3 dice. You have 3 chances to roll one of these:\n" +
                    "4-5-6: Automatic win, and noone else gets to roll. \n" +
                    "1-2-3: Automatic lose (even if it's your first roll)\n" +
                    "double: If 2 dice match, your score is the 3rd die.\n" +
                    "triple: If all 3 match, that's better than any double,\n" +
                    "        but can still be beat by a higher triple or a 4-5-6.\n" +
                    "press ENTER to roll when you think you've got it");

                Console.ReadLine();
            }
            else if (knowHowToPlay == "y")
            {
                Console.WriteLine("Well sheeeoooot, you city slickers know everything :) \n" +
                    "Let's get rollin!\n" +
                    "Press ENTER to roll");
                Console.ReadLine();
            }

           bool done = false;
while(!done)
        {
            int playerOneScore = 0;
            int playerTwoScore = 0;
            bool gotScore = false;
            int turnsLeft = 3;
            bool gameOver = false;
            while (!gotScore)
            {
                Random rnd = new Random();
                int die1 = rnd.Next(1, 7); // creates a number between 1 and 6 
                int die2 = rnd.Next(1, 7);
                int die3 = rnd.Next(1, 7);


                List<int> PlayerOneRoll = new List<int>();
                PlayerOneRoll.Add(die1);
                PlayerOneRoll.Add(die2);
                PlayerOneRoll.Add(die3);



                Console.WriteLine(die1 + ", " + die2 + ", " + die3);

                if (PlayerOneRoll.Contains(4) && PlayerOneRoll.Contains(5) && PlayerOneRoll.Contains(6))
                {
                    gotScore = true;
                    gameOver = true;
                    playerOneScore = 456;
                    Console.WriteLine("4-5-6! You win!");
                    Console.ReadLine();
                   
                }
                else if (PlayerOneRoll.Contains(1) && PlayerOneRoll.Contains(2) && PlayerOneRoll.Contains(3))
                {
                    gotScore = true;
                    gameOver = true;
                    playerOneScore = 0;
                    Console.WriteLine("1-2-3.You Lose!");
                    Console.ReadLine();
                    
                }
                else if (die1 == die2 && die2 == die3)
                {
                    gotScore = true;
                    playerOneScore = die2 + 30;
                    Console.WriteLine("Trip - " + die2 + "'s. Nice roll, champ.");
                    Console.ReadLine();
                }
                else if (die1 == die2)
                {
                    gotScore = true;
                    playerOneScore = die3;
                    Console.WriteLine("You scored a " + die3 + ".");
                    Console.ReadLine();
                }
                else if (die1 == die3)
                {
                    gotScore = true;
                    playerOneScore = die2;
                    Console.WriteLine("You scored a " + die2 + ".");
                    Console.ReadLine();
                }
                else if (die2 == die3)
                {
                    gotScore = true;
                    playerOneScore = die1;
                    Console.WriteLine("You scored a " + die1 + ".");
                    Console.ReadLine();
                }
                else
                {
                    
                    Console.WriteLine("Nothin. Roll again");
                    Console.ReadLine();
                    turnsLeft--;
                    if (turnsLeft == 0)
                        {
                            Console.WriteLine("You rolled 3 times and got NOTHING, so your score remains 0");
                            gotScore = true;   
                        }
                }
            }

                if (!gameOver)
                {
                    Console.WriteLine("My turn. *rolls dice*");
                    Console.ReadLine();


                    turnsLeft = 3;
                    gotScore = false;
                    while (!gotScore)
                    {
                        Random rnd = new Random();
                        int die1 = rnd.Next(1, 7); // creates a number between 1 and 6 
                        int die2 = rnd.Next(1, 7);
                        int die3 = rnd.Next(1, 7);

                        List<int> PlayerTwoRoll = new List<int>();
                        PlayerTwoRoll.Add(die1);
                        PlayerTwoRoll.Add(die2);
                        PlayerTwoRoll.Add(die3);

                        Console.WriteLine(die1 + ", " + die2 + ", " + die3);

                        if (PlayerTwoRoll.Contains(4) && PlayerTwoRoll.Contains(5) && PlayerTwoRoll.Contains(6))
                        {
                            gotScore = true;
                            playerTwoScore = 456;
                            Console.WriteLine("4-5-6! I'm the Winner! *fires pistols* ");
                            Console.ReadLine();
                        }
                        else if (PlayerTwoRoll.Contains(1) && PlayerTwoRoll.Contains(2) && PlayerTwoRoll.Contains(3))
                        {
                            gotScore = true;
                            playerTwoScore = 0;
                            Console.WriteLine("1-2-3.I Lost!");
                            Console.ReadLine();
                        }
                        else if (die1 == die2 && die2 == die3)
                        {
                            gotScore = true;
                            playerTwoScore = die2 + 30;
                            Console.WriteLine("Trip - " + die2 + "'s.");
                            Console.ReadLine();
                        }
                        else if (die1 == die2)
                        {
                            gotScore = true;
                            playerTwoScore = die3;
                            Console.WriteLine("I scored a " + die3 + ".");
                            Console.ReadLine();
                        }
                        else if (die1 == die3)
                        {
                            gotScore = true;
                            playerTwoScore = die2;
                            Console.WriteLine("I scored a " + die2 + ".");
                            Console.ReadLine();
                        }
                        else if (die2 == die3)
                        {
                            gotScore = true;
                            playerTwoScore = die1;
                            Console.WriteLine("I scored a " + die1 + ".");
                            Console.ReadLine();
                        }
                        else
                        {

                            Console.WriteLine("Nothin. *rolls again*");
                            Console.ReadLine();
                            turnsLeft--;
                            if (turnsLeft == 0)
                            {
                                Console.WriteLine("I rolled 3 times and got NOTHING, so my score remains 0");
                                gotScore = true;   
                            }
                        }
                    }
                }
                string keepGoing;
            if (playerOneScore > playerTwoScore)
            {
                Console.WriteLine("You Win! Good game, potnah. Care to play again? (y/n)");
                keepGoing = Console.ReadLine();
                    if(keepGoing == "n")
                    {
                        done = true;
                    }
                }
            else if (playerOneScore < playerTwoScore)
            {
                Console.WriteLine("Yeehaw! I won! Good game, potnah. Care to play again? (y/n)");
                keepGoing = Console.ReadLine();
                    if (keepGoing == "n")
                    {
                        done = true;
                    }
            }
            else if (playerOneScore == playerTwoScore)
                {
                    Console.WriteLine("Looks like it's a draw! Care to play again? (y/n)");
                    keepGoing = Console.ReadLine();
                    if (keepGoing == "n")
                    {
                        done = true;
                    }
                }
            
        }

        }
        }
    }

