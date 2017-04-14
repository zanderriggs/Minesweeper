using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Minesweeper.Classes
{

    class Mine : Spaces
    {
        static Random rnd = new Random();

        //private values here
        private int x = 0;
        private int y = 0;
        private string appearance = "";

        //Default constructor
        public Mine()
        {

        }

        //Mine constructor
        public Mine(int x, int y, string appearance = "")
        {
            this.x = x;
            this.y = y;
            this.appearance = "";
        }

        //PlantMines() - to randomly place mines in field
        public class PlantMines
        {
            Mine mine = new Mine(rnd.Next(1, 26), rnd.Next(1, 26));

        }
        //public int PlantMines()
        //{
        //    for (int i = 0; i < 25; i++)
        //        Console.WriteLine(r.Next(1, 50).ToString());

        //}

        //get sets
        //public int X
        //{
        //    get { return x; }
        //    set { x = value; }
        //}

        //public int Y
        //{
        //    get { return y; }
        //    set { y = value; }
        //}

        //public string Appearance
        //{
        //    get { return appearance; }
        //    set { appearance = value; }
        //}
    }
}


    

