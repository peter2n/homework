using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Circle:IDrawable 
    {

        public Circle(int radius)
        {
            this.Radius = radius;
        }


        public int Radius { get;  }

        public void Draw()
        {

        }
    }
}
