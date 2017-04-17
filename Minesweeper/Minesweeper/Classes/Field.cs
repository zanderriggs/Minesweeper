using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minesweeper.Classes;

namespace Minesweeper.Classes
{
    class Field
    {

        static Random rnd = new Random();

        //private values
        private int sideLength = 0;
        private Spaces[,] board;

        public Field(int sideLength)
        {
            this.sideLength = sideLength;
            board = new Spaces[this.sideLength + 2,this.sideLength + 2];
            PopulateField();
            PlantMines(board);
        }

        public int SideLength
        {
            get { return sideLength; }
            set { sideLength = value; }
        }

        private void PopulateField()
        {
            //Fills the constructed 'Field' object
            //for each open position in the array of arrays, create and instert a Spaces object

            for (int i = 0; i <= (sideLength - 1); i++)
            {
                for (int j = 0; j <= (sideLength - 1); j++)
                {
                    Spaces space = new Spaces(i, j, "#");
                    board[i, j] = space;
                }
            }

            for (int i = 0; i < sideLength; i++)
            {
                Spaces flatBorder = new Spaces(sideLength, i, "_");
                board[sideLength, i] = flatBorder;
            }

            for (int i = 0; i < sideLength; i++)
            {
                Spaces upBorder = new Spaces(sideLength, i, "|");
                board[i, sideLength] = upBorder;
            }

            for (int i = 0; i < sideLength; i++)
            {
                Spaces gridYValue = new Spaces(sideLength, i, $"{(yValues)i}");
                board[(sideLength + 1), i] = gridYValue;
            }

            for (int i = 0; i < sideLength; i++)
            {
                Spaces gridXValue = new Spaces(sideLength, i, $"{(xValues)i}");
                board[i, (sideLength + 1)] = gridXValue;
            }

            for (int i = sideLength; i <= (sideLength + 1); i++)
            {
                for (int j = sideLength; j <= (sideLength + 1); j++)
                {
                    Spaces space = new Spaces(i, j, " ");
                    board[i, j] = space;
                }
            }
            
        }

        private void PlantMines(Spaces[,] board)
        {
            double numberOfMines = Math.Round((sideLength * sideLength) * .3);
            //int r = rnd.Next(0, (sideLength-1));
            for (int i = 1; i <= numberOfMines; i++)
            {
                //Random randNumber = new Random();
                int rand1 = rnd.Next(0, sideLength - 1);
                int rand2 = rnd.Next(0, sideLength - 1);
                Mine Mine = new Mine(rand1, rand2, "#");
                board[rand1, rand2] = Mine;
            }

        }

        public void Draw() //method to write contents of Field array to console
        {
            //code to console.write contents of 'Field'
            //creates border on Field object
            Console.Clear();

            for (int i = 0; i <= sideLength + 1; i++)
            {
                for (int j = 0; j <= sideLength + 1; j++)
                {
                    Console.Write(board[i, j].Appearance + "   ");
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }

        public bool Turn(int y, int x)//reveals if a space is a mine or not
        {
            //if statements for counting mines surrounding the space or triggering endgame
            if (board[y, x] is Spaces)
            {
                return false;
                //board[x, y].Sweep();
            }
            else
            {
                return true;
            }
        }
        public void Flag(int y, int x) //turn space into '!'
        {
            //turns object.Appearance to '!'
            board[y, x].Appearance = "!";
        }

        public void Question(int y, int x) //turn space appearance into '?'
        {
            //turns object.Appearance to '?'
            board[y, x].Appearance = "?";
        }
        public int Sweep(int y, int x)
        {
            int mineCount = 0;
            //Check above
            for (int i = x - 1; i < 3; i++)
            {
                if (board[i, y] is Mine)
                {
                    mineCount++;
                }
            }
            //Check below
            for (int i = x - 1; i < 3; i++)
            {
                if (board[i, y] is Mine)
                {
                    mineCount++;
                }
            }
            //Check left
            if (board[x - 1, y] is Mine)
            {
                mineCount++;
            }
            else if (board[x + 1, y] is Mine)
            {
                mineCount++;
            }
            return mineCount;
        }
        public void Boom()
        {
            //Reveal all mines
            for (int i = 0; i < board.Length; i++)
            {
                for (int j = 0; j < board.Length; j++)
                {
                    if (board[i, j] is Mine)
                    {
                        board[i, j].Appearance = "X";
                    }
                }
            }
            Console.Clear();
            Draw();
            //Print lose text
            Console.WriteLine("You lose :(");
        }
    }
}
