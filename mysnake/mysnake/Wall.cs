using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mysnake
{
    class Wall : GameObject

    {
        public Wall(Point firstpoint, ConsoleColor color, char sign) : base(firstpoint, color, sign)
        {

        }
        public void loadlevel(GameLevel level)
        {
            string name ="";
            switch (level) {
                case GameLevel.First:
                    name = "level2.txt";
                    break;
                case GameLevel.Second:
                    name = "level2.txt";
                    break;
                case GameLevel.Bonus:
                    name = "bonuslevel.txt";
                    break;
                default:
                    break;
            }

            FileStream fs = new FileStream(name, FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            string line;
            int y = 0;
            while((line = sr.ReadLine()) != null)
            {       
                for(int x = 0; x < line.Length; x++)
                {
                   
                    if (line[x] == '#')
                    {
                        this.body.Add(new Point { X = x, Y = y });

                    }
                }
                y++;
            }
            sr.Close();
            fs.Close(); 
            
        }
    }
}
