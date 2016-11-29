using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random generator = new Random();
            List<Shape> shapeList = new List<Shape>();
            String description;
            double multiplier = 10.0;

            for(int i = 0; i < 10; i++)
            {
                if(generator.NextDouble()<0.5)
                {
                    shapeList.Add(ShapeGenerator.getTriangle(generator, out description, multiplier));
                }
                else
                {
                    shapeList.Add(ShapeGenerator.getPolygon(generator, out description, (int) (generator.NextDouble()*10), multiplier));
                }
                Console.WriteLine(description);
            }

            foreach(Shape shape in shapeList)
            {
                shape.Draw();
            }
        }
    }
}
