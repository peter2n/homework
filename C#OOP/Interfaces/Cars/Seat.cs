using System;
using System.Collections.Generic;
using System.Text;

namespace Cars
{
    class Seat : ICar
    {
        public Seat(string model, string color)
        {
            this.Model = model;
            this.Color = color;
        }
        public string Model { get; set; }
        public string Color { get; set; }
        public string Start()
        {
            return "Engine start";
        }
        public string Stop()
        {
            return "Breaaak";
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.Color);
            sb.Append(" ");
            sb.Append(this.GetType ().Name);
            sb.Append(" ");
            sb.Append(this.Model);

            return sb.ToString() ;
        }
    }
}
