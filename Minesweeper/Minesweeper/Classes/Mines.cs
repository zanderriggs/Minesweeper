using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Minesweeper.Classes;

namespace Minesweeper.Classes
{

    class Mine : Spaces
    {

        //private values here
        private int x = 0;
        private int y = 0;
        private string appearance = "";

        //Default constructor
        public Mine()
        {

        }

        //Mine constructor
        public Mine(int x, int y, string appearance)
        {
            this.x = x;
            this.y = y;
            this.appearance = appearance;
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
    }
}


    

