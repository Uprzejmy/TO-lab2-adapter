using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Triangle : Shape
    {
        Point2D a;
        Point2D b;
        Point2D c;

        public Triangle(Point2D a, Point2D b, Point2D c)
        {
            this.a = a;
            this.b = b;
            this.c = c;
        }

        public override void Draw()
        {
            Console.WriteLine("Rysuję trójkąt o polu: " + Area + ", złożony z punktów:");
            Console.WriteLine("    " + a.ToString());
            Console.WriteLine("    " + b.ToString());
            Console.WriteLine("    " + c.ToString());
        }

        public override void translate(Point2D vector)
        {
            this.a = this.a + vector;
            this.b = this.b + vector;
            this.c = this.c + vector;
        }

        public override double Area
        {
            get
            {
                return 0.5 * Math.Abs((b.X - a.X) * (c.Y - a.Y) - (b.Y - a.Y) * (c.X - a.X));
            }
        }

        public override string getDescription()
        {
            return "To jest trójkąt złożony z punktów" + this.a.ToString() + " " + this.b.ToString() + " " + this.c.ToString();
        }

        public override void translate(Point3D vector)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return this.a.ToString() + " " + this.b.ToString() + " " + this.c.ToString();
        }

    }
}
