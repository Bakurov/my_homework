using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization.Formatters;
using System.Text;
using System.Threading.Tasks;

namespace my_homework
{
    class Program
    {
        static void Main()
        {
            Console.SetWindowSize(70, 50);
            Console.Clear();
            /*var rand = new Random();
            var point1 = rand.Next(Console.WindowWidth - 15 );
            var point2 = rand.Next(Console.WindowHeight - 15 );
            var obj=new Figur(point1,point2,15);
            obj.Show();
            point1 = rand.Next(Console.WindowWidth - 15 );
            point2 = rand.Next(Console.WindowHeight - 15 );
            var obj1 = new Figur(point1, point2, 15);
            obj1.Show();*/
            ConsoleKeyInfo clik;
            var obj = new Figur(10, 20, 15);
            var obj1 = new Figur(40, 10, 15);
            var obj2 = new Figur(0, 0, 5);
            do
            {
                obj.Show();
                obj1.Show();
                obj2.Show();
                clik = Console.ReadKey();
                if (clik.Key==ConsoleKey.LeftArrow)
                {
                    obj2.SetNewPosX(-1);
                    if (obj2 == obj)
                    {
                        obj2.SetNewPosX(1);
                    }
                    if (obj2 == obj1)
                    {
                        obj2.SetNewPosX(1);
                    }
                }
                if (clik.Key == ConsoleKey.RightArrow)
                {
                    obj2.SetNewPosX(1);
                    if (obj2 == obj)
                    {
                        obj2.SetNewPosX(-1);
                    }
                    if (obj2 == obj1)
                    {
                        obj2.SetNewPosX(-1);
                    }
                }
                if (clik.Key == ConsoleKey.UpArrow)
                {
                    obj2.SetNewPosY(-1);
                    if (obj2 == obj)
                    {
                        obj2.SetNewPosY(1);
                    }
                    if (obj2 == obj1)
                    {
                        obj2.SetNewPosY(1);
                    }
                }
                if (clik.Key == ConsoleKey.DownArrow)
                {
                    obj2.SetNewPosY(1);
                    if (obj2 == obj)
                    {
                        obj2.SetNewPosY(-1);
                    }
                    if (obj2 == obj1)
                    {
                        obj2.SetNewPosY(-1);
                    }
                }
                Console.Clear();
                
            } while (clik.Key != ConsoleKey.Escape);

            for (var g = 0; g < Console.WindowWidth; g++)
            {
                Console.SetCursorPosition(g,Console.WindowHeight-5);
                Console.WriteLine("_");
            }
            //Console.WriteLine(Console.WindowWidth +"/"+ Console.WindowHeight);
        }
    }
}
