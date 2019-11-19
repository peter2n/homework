using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    interface ICar
    {
        public string Model { get; set; }

        public string Color { get; set; }

        public abstract string Start();

        public abstract string Stop();


    }
}
