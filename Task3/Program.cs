using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task3
{
    public class Point
    {
        string sign = ".";
        public List<Point> points = new List<Point>();
        public int x;
        public int y;

        public Point(int x, int y)
        {
            this.x = x;
            this.y = y;

        }
         static void FindiSin()
            {
                Thread.Sleep(1000);
                while (true)
                {
                    double sinAngle;
                    for (int x=1; x<360; x++)
                    {
                     double degrees = 1 + x;
                    double angle = Math.PI * degrees / 180.0;
                        sinAngle = Math.Sin(angle);
                        Console.WriteLine(sinAngle);
                    }
                }
               
            }
        public void Draw()
        {
            for (int i = 0; i < points.Count; ++i)
            {
                Console.SetCursorPosition(points[i].x, points[i].y);
                Console.Write(sign);
            }
        }

       
        class Program
        {
            
            static void Main(string[] args)
            {

                var th = new Thread(FindiSin);
                th.Start();
                Thread.Sleep(100);

            }
      
        }
    }
}
