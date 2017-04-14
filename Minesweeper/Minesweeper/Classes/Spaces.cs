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
        private string appearance = "#";

        //Default constructor
        public Spaces()
        {

        }

        //constructor
        public Spaces(int x, int y, string appearance = "#")
        {
            this.x = x;
            this.y = y;
            this.appearance = "#";
        }

        public void Turn()//reveals if a space is a mine or not
        {
            //if statements for counting bombs surrounding the space or triggering endgame
        }
        public void Flag() //turn space into '!'
        {
            //turns object.Appearance to '!'

        }

        public void Question() //turn space appearance into '?'
        {
            //turns object.Appearance to '!'
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

