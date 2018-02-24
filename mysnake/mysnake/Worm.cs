using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysnake
{
     public class Worm : GameObject
    {
        public Worm(Point firstpoint, ConsoleColor color, char sign) : base(firstpoint, color, sign)
        {

        }
        
        public void Move(int dx,int dy)
        {
            Point newheadpos = new Point { X = body[0].X + dx, Y = body[0].Y + dy };
            for(int i = body.Count-1; i > 0; i--)
            {
                body[i].X = body[i - 1].X;
                body[i].Y = body[i - 1].Y;

            }
            body[0] = newheadpos;
        }
    }
}
