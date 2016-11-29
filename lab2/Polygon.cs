using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public class Polygon : Shape
    {
        private List<Triangle> triangles;

        public Polygon()
        {
            triangles = new List<Triangle>();
        }

        public void addTriangle(Triangle triangle)
        {
            triangles.Add(triangle);
        }

        public override void Draw()
        {
            Console.WriteLine("Rysuję wielokat o polu: " + Area + ", złożony z: " + triangles.Count + " trojkatow:");
            foreach(Triangle triangle in triangles)
            {
                Console.WriteLine("    " + triangle.ToString());
            }
        }

        public override double Area
        {
            get
            {
                double area = 0.0;
                foreach(Triangle triangle in triangles)
                {
                    area += triangle.Area;
                }

                return area;
            }
        }

        public override void translate(Point2D vector)
        {
            throw new NotImplementedException();
        }

        public override void translate(Point3D vector)
        {
            throw new NotImplementedException();
        }
    }
}
