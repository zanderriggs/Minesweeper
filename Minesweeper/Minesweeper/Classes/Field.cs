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

        public double NumberOfMines(int sideLength) //calculates # of mines for field
        {
            double numberOfMines = Math.Round((sideLength * sideLength) * .15);
            return numberOfMines; //returns the number of mines to be generated
        }

        //public Spaces PopulateField()
        //{
        //    //Fills the constructed Field object
        //    //for each open position in the array of arrays, create and instert a Spaces object

        //}

        //public Mine PlantMines()
        //{
        //    //takes 'numberOfMines' from NumberOfMines method to generate that many mines and place them in Field object

        //}

        public void Draw() //method to write contents of Field array to console
        {
            //code to console.write contents of 'Field'

        }

        public int SideLength
        {
            get { return sideLength; }
            set { sideLength = value; }
        }
    }
}
