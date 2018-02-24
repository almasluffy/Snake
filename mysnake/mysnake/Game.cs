using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace mysnake
{
    enum GameLevel
    {
        First,
        Second,
        Bonus
    }
    public class Game
    {
        Worm worm;
        Food food;
        Wall wall;
        GameLevel gameLevel;
        public int k = 0;
        public bool alive = true;

        public void Start()
        {
            Console.Clear();
            wall.Draw();
            worm.Draw();
            food.Draw();
            Console.SetCursorPosition(5, 1);
            Console.Write("Score: ");
        }

        public bool isalive;
        //List<GameObject> g_object = new List<GameObject>();
        //List<GameObject> g_wall = new List<GameObject>();
       /* public void lvl(int k)
        {
            if (k < 3)
            {
                gameLevel = GameLevel.First;
                wall.loadlevel(gameLevel);
            }
            if (k >= 3)
            {
                gameLevel = GameLevel.Second;
                wall.loadlevel(gameLevel);
            }
            if (k >= 6)
            {
                gameLevel = GameLevel.Bonus;
                wall.loadlevel(gameLevel);
            }
        }*/

        public Game()
        {
            isalive = true;
            worm = new Worm(new Point { X = 10, Y = 10 }, ConsoleColor.DarkBlue, '■');
            food = new Food(new Point { X = 12, Y = 10 }, ConsoleColor.Green, '$');
            wall = new Wall(null, ConsoleColor.Red, '☺');
            //Console.Clear();
            wall.loadlevel(gameLevel);

           
        }


       
        public void Process(ConsoleKeyInfo bt)
        {
            switch (bt.Key)
            {
                case ConsoleKey.UpArrow:
                    worm.Clear();
                    worm.Move(0, -1);
                    worm.Draw();
                    break;
                case ConsoleKey.DownArrow:
                    worm.Clear();
                    worm.Move(0, 1);
                    worm.Draw();
                    break;
                case ConsoleKey.LeftArrow:
                    worm.Clear();
                    worm.Move(-1, 0);
                    worm.Draw();
                    break;
                case ConsoleKey.RightArrow:
                    worm.Clear();
                    worm.Move(1, 0);
                    worm.Draw();
                    break;
                case ConsoleKey.Escape:
                    Console.Clear();
                    Console.SetCursorPosition(10, 5);
                    Console.WriteLine("You left the game.");
                    Console.SetCursorPosition(10, 6);
                    Console.WriteLine("Your score: " + k);
                    isalive = false;
                    break;
            }
            
            if (worm.body[0].Equals(food.body[0]))
            {
                k++;
                worm.body.Add(new Point { X = food.body[0].X, Y = food.body[0].X });

                food.GenerateRandom();
                while (wall.IsPointBelong(food.body[0]) || worm.IsPointBelong(food.body[0]))
                {
                    food.GenerateRandom();
                }
                food.Draw();
                Console.SetCursorPosition(12, 1);
                Console.Write(k);
            }
            else if(wall.IsPointBelong(worm.body[0]))
            {
                Console.Clear();
                Console.SetCursorPosition(10, 5);
                Console.WriteLine("Game Over!!!");
                Console.SetCursorPosition(10, 6);
                Console.WriteLine("Your score: " + k);
                isalive = false;
            }
           
        }
        
    }
}
