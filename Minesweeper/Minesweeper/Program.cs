using System;
using Minesweeper.Classes;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper
{
    enum xValues { A, B, C, D, E, F, G, H, I, J, K, L, M }
    enum yValues { Z, Y, X, W, V, U, T, S, R, Q, P, O, N }
    
    class Program
    {
        static void Main(string[] args)
        {
            string answer;
            bool quit = false;
            bool winCheck = false;

            string userName;
            int sideLength;
            string userChoice;
            string[] userSpace;
            int yCoord = 0;
            int xCoord = 0;
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
                    board.Draw();

                    Console.WriteLine("Your options:");
                    Console.WriteLine("     Expose(E)  Flag(F)  Mark(M)  Quit(Q)");
                    Console.Write("     Enter your selection: ");

                    userChoice = Console.ReadLine().ToLower();

                    //Console.Write("Please enter two coordinates separated by a space (i.e. A Z) to select a tile: ");
                    //userSpace = (Console.ReadLine().ToUpper()).Split(' ');
                    //yCoord = (int)((yValues)Enum.Parse(typeof(yValues), userSpace[0]));
                    //xCoord = (int)((xValues)Enum.Parse(typeof(xValues), userSpace[1]));
                    
                    switch(userChoice)
                    {
                        case "e":
                            Console.Write("Please enter two coordinates separated by a space (i.e. A Z) to select a tile: ");
                            userSpace = (Console.ReadLine().ToUpper()).Split(' ');
                            yCoord = (int)((yValues)Enum.Parse(typeof(yValues), userSpace[1]));
                            xCoord = (int)((xValues)Enum.Parse(typeof(xValues), userSpace[0]));
                            board.Turn(xCoord, yCoord);
                            break;

                        case "f":
                            Console.Write("Please enter two coordinates separated by a space (i.e. A Z) to select a tile: ");
                            userSpace = (Console.ReadLine().ToUpper()).Split(' ');
                            yCoord = (int)((yValues)Enum.Parse(typeof(yValues), userSpace[1]));
                            xCoord = (int)((xValues)Enum.Parse(typeof(xValues), userSpace[0]));
                            board.Flag(xCoord, yCoord);
                            break;

                        case "m":
                            Console.Write("Please enter two coordinates separated by a space (i.e. A Z) to select a tile: ");
                            userSpace = (Console.ReadLine().ToUpper()).Split(' ');
                            yCoord = (int)((yValues)Enum.Parse(typeof(yValues), userSpace[1]));
                            xCoord = (int)((xValues)Enum.Parse(typeof(xValues), userSpace[0]));
                            board.Question(xCoord, yCoord);
                            break;

                        case "q":
                            quit = true;
                            break;

                        default:
                            Console.WriteLine("That is not a user option.");
                            break;
                    }

                winCheck = board.Win();
                    
                }
                while (winCheck == false && quit == false);

                Console.WriteLine("Game Over");
                Console.WriteLine("Continue? (y/n): ");
                answer = Console.ReadLine();

            }
            while (answer.ToLower() == "y");

            Console.Write("Goodbye, you can brave the minefield again another day.");
        }
        
    }
    
}
