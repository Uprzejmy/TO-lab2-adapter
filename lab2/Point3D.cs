using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Point3D : IDrawable, IComparable
    {
        protected Point2D point2d;
        protected double z;

        public Point3D(double x, double y, double z)
        {
            this.point2d = new Point2D(x, y);
            this.z = z;
        }

        public double Z
        {
            get { return this.z; }
            set { this.z = value; }
        }

        public void Draw()
        {
            Console.WriteLine("Punkt: " + this.ToString());
        }

        private static Point3D toVector(Object obj)
        {
            if (obj is Point3D)
            {
                return obj as Point3D;
            }

            throw new ArgumentException("Obiekt nie jest wektorem 3D");
        }

        public int CompareTo(object obj)
        {
            Point3D tmp = Point3D.toVector(obj);
            int cmp = point2d.CompareTo(tmp.point2d);
            if (cmp == 0)
                return this.z.CompareTo(tmp.z);
            return cmp;
        }

        public override String ToString()
        {
            return "[" + point2d.X.ToString() + " " + point2d.Y.ToString() + " " + z.ToString() + "]";
        }
    }
}
