using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void XmlS(List<Point> points)
        { }

        static List<Point> XmlD()
        { return null; }
        static void Main(string[] args)
        {
            List<Point> points = new List<Point>();
            points.Add(new Point(10, 15, "1"));
            points.Add(new Point(45, 100, "2"));
            points[0].x = 0;

            foreach (Point item in points)
            {
                item.Print();
            }
            Console.WriteLine("***");
            for (int i = 0; i < points.Count; i++)
            {
                points[i].Print();
            }
        }
    }

    public class Point
    {
        public int x;
        public int y;
        public string label;
        public Point(int x, int y, string label)
        {
            this.x = x;
            this.y = y;
            this.label = label;
        }

        public Point()
        { }

        public void Print()
        {
            Console.WriteLine("X = {0}\nY = {1}\nLabel: {2}", x, y, label);
        }
    }
}
