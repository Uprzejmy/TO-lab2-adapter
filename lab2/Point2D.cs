using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Point2D : IDrawable
    {
        protected double x;
        protected double y;

        public Point2D(double x, double y)
        {
            this.x = x;
            this.y = y;
        }

        public double Y
        {
            get { return this.y; }
            set { this.y = value; }
        }

        public double X
        {
            get { return this.x; }
            set { this.x = value; }
        }

        private static Point2D toVector(Object obj)
        {
            if (obj is Point2D)
            {
                return obj as Point2D;
            }
            throw new ArgumentException("Obiekt nie jest wektorem 2D");
        }

        public override bool Equals(object obj)
        {
            Point2D tmp = Point2D.toVector(obj);

            if (this.x == tmp.x && this.y == tmp.y) 
                return true;

            return false;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        public int CompareTo(object obj)
        {
            Point2D tmp = Point2D.toVector(obj);
            int cmp = this.x.CompareTo(tmp.x);
            if (cmp == 0) 
                return this.y.CompareTo(tmp.y);
            return cmp;
        }

        public void Draw()
        {
            Console.WriteLine("Punkt: " + this.ToString());
        }

        public override String ToString()
        {
            return "[" + x.ToString() + " " + y.ToString() + "]";
        }

        public static Point2D operator +(Point2D l, Point2D r)
        {
            return new Point2D(l.x + r.x, l.y + r.y);
        }

        public static Point2D operator -(Point2D l, Point2D r)
        {
            return new Point2D(l.x - r.x, l.y - r.y);
        }

        public static Point2D operator *(Point2D l, double a)
        {
            return new Point2D(l.x * a, l.y * a);
        }

        public static Point2D operator *(double a, Point2D l)
        {
            return new Point2D(l.x * a, l.y * a);
        }

        public static Point2D operator /(Point2D l, double a)
        {
            return new Point2D(l.x / a, l.y / a);
        }

        public static Point2D operator /(double a, Point2D l)
        {
            return new Point2D(l.x / a, l.y / a);
        }
    }
}
