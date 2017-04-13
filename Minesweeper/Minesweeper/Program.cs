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


            //create Field. Field = array of arrays based on the sidelength paramater set by the user
            Array[,] Field = new Array[sideLength + 2, sideLength + 2];



            //Run game within do/while loop
            //do
            //{
            //    //do
            //    //{
            //    //    //run game

            //    //    //check for mines
            //    //    //if (Field[1, 2] is Mine)
            //    //    //{

            //    //    //}


            //    //}
            //    //while (winGame = false);
            //}
            //while (continue.ToLower() = "y");
            


        }
    }
}
