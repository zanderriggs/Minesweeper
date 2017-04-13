using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Classes
{
    class Spaces 
    
    {
        //private values here
        private int x = 0;
        private int y = 0;

        //Default constructor
        public Spaces()
        {

        }

        //constructor
        public Spaces(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //get sets
        public int X
        {
            get { return x; }
            set { value = x; }
        }
        public int Y
        {
            get { return y; }
            set { value = y; }
        }

        public int PlantMines() // Method
            {
                Random r = new Random();
                for (int i = 0; i < 25; i++)
                Console.WriteLine(r.Next(1, 50).ToString());

            }
    
    }
}
