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
        private string appearance = "";

        //Default constructor
        public Spaces()
        {

        }

        //constructor
        public Spaces(int x, int y, string appearance = "")
        {
            this.x = x;
            this.y = y;
            this.appearance = "";
        }

        //get sets
        public int X
        {
            get { return x; }
            set { x = value; }
        }
        public int Y
        {
            get { return y; }
            set { y = value; }
        }
        public string Appearance
        {
            get { return appearance; }
            set { appearance = value; }
        }

        public int RandomNumber(int rand1, int rand2)
        {
            Random randNumber = new Random();
            int rand1 = Random.Next(0, sideLength - 1);
            int rand2 = Random.Next(0, sideLength - 1);
        }
    }
}

