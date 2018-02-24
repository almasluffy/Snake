using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysnake
{
    public class Food : GameObject
    {
        public Food(Point firstpoint, ConsoleColor color, char sign) : base(firstpoint, color, sign)
        {

        }

        public void GenerateRandom()
        {
            Random rd = new Random();
            this.body[0] = new Point { X = rd.Next(6, 31), Y = rd.Next(4, 13) };
        }
        
    }
}
