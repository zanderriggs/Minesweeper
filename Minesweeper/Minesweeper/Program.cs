using System;
using Minesweeper.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    class Program
    {
        

        static void Main(string[] args)
        {
            string userName;
            int sideLength;
            string userBool;
            string userChoice;
            string userSpace;

            Console.WriteLine("Hello there, you think you are brave enough to navigate the minefield?");
            Console.Write("Enter your name so we know who is trespassing here... ");

            userName = Console.ReadLine();


            //do
            //{

            Console.WriteLine($"Hi, {userName}, what size minefield can you handle?");
                Console.Write("Enter a number between 3 and 13 to indicate the size of your desired minefield: ");

                sideLength = int.Parse(Console.ReadLine());

                Field board = new Field(sideLength);

                board.Draw();

                do
                {
                    Console.WriteLine("You have  options:");
                    Console.WriteLine("  To expose a tile, enter E");
                    Console.WriteLine("  To flag a mine, enter F");
                    Console.WriteLine("  To mark a suspected mine, enter S");
                    Console.WriteLine("  If you want to quit, enter Q");
                    Console.Write($"  What is your choice, {userName}? ");

                    userChoice = Console.ReadLine().ToLower();


                }

                while (userChoice != "q");

                if (userChoice == "q")
                {
                    Console.Clear();
                    Console.Write("I see that you cannot handle the minefield. At least you still have your life!");
                }


                else
                {
                    Console.Write("Please enter two coordinates (i.e. ZB) to select a space: ");
                    userSpace = Console.ReadLine().ToUpper();
                    
                }
            }


            //Run game within do/while loop? -z
            //do
            //{
            //    do
            //    {
            //        run game

            //        check for mines
            //        if (Field[1, 2] is Mine)
            //            {

            //            }
            //    }
            //    while (endGame = false);
            //    if (endGameWin = true)
            //    {
            //        Console.Write("You win!");
            //    }
            //    if (endGameLose = true)
            //    {
            //        Console.Write("You lose :(");
            //    }
            //    Console.WriteLine("Woudld you like to play again (y/n)?");
            //    continue = Console.ReadLine();
            //}
            //while (continue.ToLower() = "y");

        }
        public void Boom()
        {
            //Reveal all mines

            //Print lose text
            Console.WriteLine("You lose :(");
        }
    }
}
