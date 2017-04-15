﻿using System;
using Minesweeper.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    enum xValues { Z, Y, X, W, V, U, T, S, R, Q, P, O, N }
    enum yValues { A, B, C, D, E, F, G, H, I, J, K, L, M }

    class Program
    {


        static void Main(string[] args)
        {
            string finalAnswer;
            string userName;
            int sideLength;
            string userChoice;
            string userSpace;
            string answer;

            Console.WriteLine("Hello there, you think you are brave enough to navigate the minefield?");
            Console.Write("Enter your name so we know who is trespassing here... ");

            userName = Console.ReadLine();


            do
            {

                Console.WriteLine($"Hi, {userName}, what size minefield can you handle?");
                Console.Write("Enter a number between 3 and 13 to indicate the size of your desired minefield: ");

                sideLength = int.Parse(Console.ReadLine());

                Field board = new Field(sideLength);

                do
                {

                    Console.Clear();
                    board.Draw();

                    Console.WriteLine("You have  options:");
                    Console.WriteLine("  To expose a tile, enter E");
                    Console.WriteLine("  To flag a mine, enter F");
                    Console.WriteLine("  To mark a suspected mine, enter S");
                    Console.WriteLine("  If you want to quit, enter Q");
                    Console.Write($"  What is your choice, {userName}? ");

                    userChoice = Console.ReadLine().ToLower();

                    if (userChoice == "q")
                    {
                        Console.Clear();
                        Console.Write("I see that you cannot handle the minefield. At least you still have your life!");
                    }
                    else
                    {
                        Console.Write("Please enter two coordinates separated by a space (i.e. Z B) to select a tile: ");
                        userSpace = Console.ReadLine().ToUpper();

                        string [] userCoords = userSpace.Split(' ');

                        int xCoord = int.Parse(typeof(xValues), userCoords[1]);
                        switch (userChoice)
                        {
                            case "E":
                                Console.WriteLine();
                                break;
                            case "F":

                                break;
                            case "S":

                                break;
                            case "Q":

                                break;
                            default:
                                Console.WriteLine("That is not a user option.");
                                break;

                        }
                    }

                    Console.WriteLine("Would you like to play again (y/n)?");
                    finalAnswer = Console.ReadLine();
                }
                while (userChoice != "q");

                Console.WriteLine("Would you like to continue (y/n)?");
                answer = Console.ReadLine();

            }
            while (finalAnswer.ToLower() == "y");

            Console.Write("Goodbye, you can brave the minefield again another day.");
        }
            
        public void Boom()
        {
            //Reveal all mines

            //Print lose text
            Console.WriteLine("You lose :(");
        }
    }
}
