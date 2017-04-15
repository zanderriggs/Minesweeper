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


            Console.WriteLine("Hello there, you think you are brave enough to navigate the minefield?");
            Console.Write("Enter your name so we know who is trespassing here... ");

            userName = Console.ReadLine();

            Console.WriteLine($"Hi, {userName}, what size minefield can you handle?");
            Console.Write("Enter a number between 3 and 13 to indicate the size of your desired minefield: ");

            sideLength = int.Parse(Console.ReadLine());

            Spaces [,] board = new Spaces[(sideLength + 2), (sideLength + 2)];

            Field field = new Field(sideLength);

            Console.Write(board[1, 2].Appearance);

            Console.ReadLine();



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
