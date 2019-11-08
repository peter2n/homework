﻿using System;
using System.Collections.Generic;
using System.Text;

namespace P01_RawData
{
    class Car
    {
        public Car(string model, Engine engine, Cargo cargo, Tire[] tires)
        {
            this.Model = model;
            this.Cargo = cargo;

            this.Tires =tires;
            this.Engine = engine;

        }

        public Cargo Cargo { get; set; }

        public Tire[] Tires { get; set; }
        public string Model { get; set; }

        public Engine Engine { get; set; }


    }
}