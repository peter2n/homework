using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    class Person
    {
        public Person(string firstName, string lastName, int age,decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;

        }


        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Age { get; private set; }
        public decimal Salary { get; private set; }

        public override string ToString()
        {
            //return $"{this.FirstName } {this.LastName } is {this.Age } years old.";
            return $"{this.FirstName } {this.LastName } receives {Salary:f2} leva.";
        }

        internal void IncreaseSalary(decimal persentage)
        {
            if (this.Age<30)
            {
                persentage /= 2;
            }

            this.Salary *= (100 + persentage) / 100;
        }
    }
}
