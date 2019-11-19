using System;
using System.Collections.Generic;
using System.Text;

namespace Shapes
{
    class Rectangle :IDrawable 
    {


        public Rectangle(int width,int height)
        {
            this.Width = width;
            this.Height = height;
        }



        public int Width { get;  }

        public int Height { get; }

        public void Draw()
        {

        }



    }
}
