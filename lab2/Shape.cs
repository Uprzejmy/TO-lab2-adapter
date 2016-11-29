using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public abstract class Shape : IDrawable
    {
        public abstract void translate(Point2D point);
        public abstract void translate(Point3D point);
        public abstract void Draw();

        public virtual double Area
        {
            get { return 0; }
        }
        public virtual double Volume
        {
            get { return 0; }
        }

        public virtual String getDescription()
        {
            return "To jest zwykły kształt";
        }
    }
}
