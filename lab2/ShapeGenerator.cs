using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public abstract class ShapeGenerator
    {
        public static Triangle getTriangle(Random r, out String desc, double multiplier = 1)
        {
            Point2D a;
            Point2D b;
            Point2D c;

            a = getPoint(r, multiplier);
            b = getPoint(r, multiplier);
            c = getPoint(r, multiplier);

            desc = "Wylosowano trójkąt o wierzchołkach " + a + " " + b + " " + c;
            return new Triangle(a, b, c);
        }

        public static Polygon getPolygon(Random r, out String desc, int nodes, double multiplier = 1)
        {
            desc = "Wylosowano wielokąt o wierzchołkach:";
            Polygon polygon = new Polygon();

            Point2D a = getPoint(r, multiplier);
            desc += " " + a;
            Point2D b = getPoint(r, multiplier);
            desc += " " + b;
            Point2D c = getPoint(r, multiplier);
            desc += " " + c;

            polygon.addTriangle(new Triangle(a, b, c));

            for(int i=3;i<nodes;i++)
            {
                a = b;
                b = c;
                c = getPoint(r, multiplier);
                desc += " " + c;
                polygon.addTriangle(new Triangle(a,b,c));
            }

            return polygon;
        }

        public static Point2D getPoint(Random r,double multiplier)
        {
            return new Point2D(r.NextDouble() * multiplier, r.NextDouble() * multiplier);
        }

    }
}
