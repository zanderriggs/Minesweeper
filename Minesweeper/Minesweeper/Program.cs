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
        enum xValues { Z, Y, X, W, V, U, T, S, R, Q, P, O, N}
        enum yValues { A, B, C, D, E, F, G, H, I, J, K, L, M}

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


            //create Field. Field = array of arrays based on the sidelength paramater set by the user
            Spaces[,] Field = new Spaces[sideLength + 2, sideLength + 2];

            //Code to populate the Field - copied from what we worked out on the board (from memory)
            for (int i = 0; i < (sideLength-1); i++)
            {
                for (int j = 0; j < (sideLength-1); j++)
                {
                    Spaces space = new Spaces(i, j, "#");
                    Field[i, j] = space;
                }
            }

            for ( int i = 0; i < sideLength; i++)
            {
                Field[sideLength, i] = new Spaces(sideLength, i, "_");
            }

            for (int i = 0; i < sideLength; i++)
            {
                Field[i, sideLength] = new Spaces(sideLength, i, "|");
            }

            for (int i = 0; i < sideLength; i++)
            {
                Field[(sideLength+1), i] = new Spaces((sideLength+1), i, $"{(yValues)i}");
            }

            for (int i = 0; i < sideLength; i++)
            {
                Field[i, (sideLength+1)] = new Spaces((sideLength+1), i, $"{(xValues)i}");
            }

            Spaces emptySpace = new Spaces((sideLength + 1), (sideLength + 1), " ");
            Field[sideLength + 1, sideLength + 1] = emptySpace;

            for (int i = 0; i < (sideLength+1); i++)
            {
                for (int j = 0; j < (sideLength+1); j++)
                {
                    Console.Write(string.Format("{0} ", Field[i, j].Appearance));
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
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
    }
}
