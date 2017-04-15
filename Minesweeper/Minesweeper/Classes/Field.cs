using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Classes
{
    class Field
    {
        enum xValues { Z, Y, X, W, V, U, T, S, R, Q, P, O, N }
        enum yValues { A, B, C, D, E, F, G, H, I, J, K, L, M }

        //private values
        private int sideLength = 0;

        //default constructor
        public Field()
        {

        }

        //Field constructor(with user input for field size)
        public Field(int sideLength)
        {
            this.sideLength = sideLength;
            //generates array
        }

        public Spaces PopulateField(ref int sideLength)
        {
            //Fills the constructed 'Field' object
            //for each open position in the array of arrays, create and instert a Spaces object
            for (int i = 0; i <= (sideLength - 1); i++)
            {
                for (int j = 0; j <= (sideLength - 1); j++)
                {
                    Spaces space = new Spaces(i, j, "#");
                    Field[i, j] = space;
                    return space;
                }
            }
        }

        //public double NumberOfMines(int sideLength) //calculates # of mines for field
        //{
        //    double numberOfMines = Math.Round((sideLength * sideLength) * .15);
        //    return numberOfMines; //returns the number of mines to be generated
        //}

        //public Mine PlantMines(int NumberOfMines)
        //{
        //    //takes 'numberOfMines' from NumberOfMines method to generate that many mines and place them in Field object

        //}

        //public void Draw() //method to write contents of Field array to console
        //{
        //    //code to console.write contents of 'Field'
        //    //creates border on Field object
        //    for (int i = 0; i < sideLength; i++)
        //    {
        //        Spaces flatBorder = new Spaces(sideLength, i, "_");
        //        Field[sideLength, i] = flatBorder;
        //    }

        //    for (int i = 0; i < sideLength; i++)
        //    {
        //        Spaces upBorder = new Spaces(sideLength, i, "|");
        //        Field[i, sideLength] = upBorder;
        //    }

        //    for (int i = 0; i < sideLength; i++)
        //    {
        //        Spaces gridYValue = new Spaces(sideLength, i, $"{(yValues)i}");
        //        Field[(sideLength + 1), i] = gridYValue;
        //    }

        //    for (int i = 0; i < sideLength; i++)
        //    {
        //        Spaces gridXValue = new Spaces(sideLength, i, $"{(xValues)i}");
        //        Field[i, (sideLength + 1)] = gridXValue;
        //    }

        //    for (int i = sideLength; i <= (sideLength + 1); i++)
        //    {
        //        for (int j = sideLength; j <= (sideLength + 1); j++)
        //        {
        //            Spaces space = new Spaces(i, j, " ");
        //            Field[i, j] = space;
        //        }
        //    }

        //    for (int i = 0; i < (sideLength + 1); i++)
        //    {
        //        for (int j = 0; j < (sideLength + 1); j++)
        //        {
        //            Console.Write($"{(Field[i, j].Appearance)} ");
        //        }
        //        Console.Write(Environment.NewLine + Environment.NewLine);
        //    }
        //}

        public int SideLength
        {
            get { return sideLength; }
            set { sideLength = value; }
        }
    }
}
