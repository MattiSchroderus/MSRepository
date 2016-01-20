using System;

namespace githubtesti123
{
    struct point
    {
        public int x;
        public int y;
    }

    class Program
    {

        static void Main(string[] args)
        {
            point coordinates = new point();
            coordinates.x = 100;
            coordinates.y = 50;

            Modifypoint(coordinates);

            Console.WriteLine("Coordinates: " + coordinates.x + "; " + coordinates.y);
            Console.ReadLine();
         
        }
        static void Modifypoint(point p)
        {
            p.x += 500;
            p.y += 1500;
        }
    }
    
}
