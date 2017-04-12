using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Classes
{
    class Mine
    {
        //private values here
        private int x = 0;
        private int y = 0;

        //Default constructor
        public Mine()
        {

        }

        //Mine constructor
        public Mine(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        //LayMines() - to randomly place mines in field

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
    }

}
