using SoftwareMetrics_2_InterfaceExample;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SoftwareMetrics_2_Shapes
{
    public interface IShape
    {
        bool IsValid();
        string Draw();
    }

    public class Coord : IShape
    {
        public int N { get; set; }

        public bool IsValid()
        {
            return N >= 0;
            //if (N >= 0) return true;
            //else return false;
        }

        public string Draw()
        {
            return N.ToString();
        }
    }
    //Point
    public class Point : IShape
    {
        public Coord X { get; set; }
        public Coord Y { get; set; }

        public Point()
        {
            X = new Coord();
            Y = new Coord();
        }

        public Point (int x, int y): this()
        {
            X.N = x;
            Y.N = y;
        }

        public Point(Coord x, Coord y): this()
        {
            X = x;
            Y = y;
        }

        public bool IsValid()
        {
            return X.IsValid() && Y.IsValid();
        }

        public string Draw()
        {
            return $"({X.Draw()}, {Y.Draw()})";
        }
    }
    
    //Line
    public class Line : IShape
    {
        public Point A { get; set; }
        public Point B { get; set; }

        public Line()
        {
            A = new Point();
            B = new Point();
        }

        public Line(Point a, Point b): this()
        {
            A = a;
            B = b;
        }

        public Line (Coord x1, Coord y1, Coord x2, Coord y2) : this()
        {
            A.X = x1;
            A.Y = y1;
            B.X = x2;
            B.Y = y2;
        }

        public Line(int x1, int y1, int x2, int y2)
        {
            A = new Point(x1, y1);
            B = new Point(x2, y2);
        }

        public bool IsValid()
        {
            //return A.X.N >= 0 && A.Y.N >= 0 && B.X.N >= 0 && B.Y.N >= 0;
            return A.IsValid() && B.IsValid();
        }

        public string Draw()
        {
            return $"{A.Draw()} {B.Draw()}";
        }

        public override string ToString()
        {
            return Draw();
        }
    }
    //Triangle
    class Triangle : IShape
    {
        public Line AB { get; set; }
        public Line BC { get; set; }
        public Line CA { get; set; }

        public bool IsValid()
        {
            return AB.IsValid() && BC.IsValid() && CA.IsValid();
        }
        public string Draw()
        {
            return $"Triangle with {AB.Draw()}, {BC.Draw()}, {CA.Draw()}";
        }
    }

    public class Shape : IShape
    {
        public List<Line> Lines { get; set; }
        public string Draw()
        {
            return string.Join(",", Lines);
        }

        public bool IsValid()
        {
            //foreach (Line line in Lines)
            //{
            //    if (line.IsValid() == false)
            //        return false;
            //}
            //return true;

            return Lines.Any(line => line.IsValid() == false) == false;
        }
    }

    class Rectangle : Shape
    {
    }
}
