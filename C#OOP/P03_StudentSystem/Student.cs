﻿namespace P03_StudentSystem
{
    using System;
    using System.Collections.Generic;

    public class Student
    {
        public double Grade { get; set; }

        public int Age { get; set; }

        public string Name { get; set; }

        public Student(string name, int age, double grade)
        {
            this.Name = name;
            this.Age = age;
            this.Grade = grade;
        }

        public override string ToString()
        {

            string view = $"{Name} is {Age} years old.";

            if (Grade >= 5.00)
            {
                view += " Excellent student.";
            }
            else if (Grade < 5.00 && Grade >= 3.50)
            {
                view += " Average student.";
            }
            else
            {
                view += " Very nice person.";
            }

            return view;
        }
    }
}