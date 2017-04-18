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
        private bool isMine = true;
        private string appearance = "";

        //Mine constructor
        public Mine(int y, int x, string appearance)
        {
            this.x = x;
            this.y = y;
            this.appearance = appearance;
        }

        //get sets
        new public int X
        {
            get { return x; }
            set { x = value; }
        }
        new public int Y
        {
            get { return y; }
            set { y = value; }
        }
        new public string Appearance
        {
            get { return appearance; }
            set { appearance = value; }
        }
        public bool IsMine
        {
            get { return isMine; }
        }
    }
}


    

