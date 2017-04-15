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
        enum xValues { Z, Y, X, W, V, U, T, S, R, Q, P, O, N }
        enum yValues { A, B, C, D, E, F, G, H, I, J, K, L, M }

        static Random rnd = new Random();

        //private values
        private int sideLength = 0;

        private Spaces[,] board;

        //default constructor
        public Field()
        {

        }

        //Field constructor(with user input for field size)
        public Field(int sideLength)
        {
            this.sideLength = sideLength;
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

        private void PlantMines()
        {
            double numberOfMines = Math.Round((sideLength * sideLength) * .15);
            //int r = rnd.Next(0, (sideLength-1));
            for (int i = 1; i <= numberOfMines; i++)
            //Console.WriteLine(r.Next(1, 50).ToString());
            {
                //Random randNumber = new Random();
                int rand1 = rnd.Next(0, sideLength - 1);
                int rand2 = rnd.Next(0, sideLength - 1);

                if ((board[rand1, rand2]).Appearance != "!")
                {
                    Mine mine = new Mine(rand1, rand2, "!");
                }

                else
                {
                    i = (i - 1);
                }

            }

        }

        public void Draw(Spaces[,] board) //method to write contents of Field array to console
        {
            //code to console.write contents of 'Field'
            //creates border on Field object

            for (int i = 0; i < (sideLength + 1); i++)
            {
                for (int j = 0; j < (sideLength + 1); j++)
                {
                    Console.Write($"{(board[i, j]).Appearance} ");
                }
                Console.Write(Environment.NewLine + Environment.NewLine);
            }
        }
    }
}
