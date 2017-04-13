using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Classes
{
    class Field
    {
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
        }

        //public Spaces PopulateField()
        //{
        //    //Filling The Field
        //    //for each open position in the array of arrays, create and instert a Spaces object
        //    for (int x = 0; x < gameBoard.Length; x++)
        //    {
        //        int y;
        //        for (y =0; y < gameBoard.Length; y++)
        //        {
        //            Spaces Space = new Spaces(x, y);
        //            gameBoard[x, y] = Space;
        //        }

        //    }

        //}

        
        //GenerateField()

        //LayMines() - maybe include this code within the Gererate Field method

        //get sets
    }
}
