using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo, Tire tire1, Tire tire2, Tire tire3, Tire tire4)
        {
            this.Model = model;



        }




        public string Model { get; set; }
        internal Engine Engine { get => engine.EnginePower ; set => engine = value; }

        private Engine engine;
    }
}
