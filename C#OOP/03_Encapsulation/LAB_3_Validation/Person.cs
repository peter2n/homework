using System;
using System.Collections.Generic;
using System.Text;

namespace PersonsInfo
{
    class Person
    {
        private string firstName;
        private string lastName;
        private int age;
        private decimal salary;

        public Person(string firstName, string lastName, int age, decimal salary)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
            this.Salary = salary;
        }
        public string FirstName
        {
            get => this.firstName;

            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException(nameof(firstName), "First name must be longer then 2 chars");
                }
                firstName = value;
            }
        }

        public string LastName
        {
            get => this.lastName;
            private set
            {
                if (value.Length < 3)
                {
                    throw new ArgumentException(nameof(lastName), "First name must be longer then 2 chars");
                }
                this.LastName = value;
            }


        }
        public int Age
        {
            get => this.age;
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException(nameof(age), "Age must be greater than zero");
                }
                this.Age = value;
            }
        }


        public decimal Salary { 
            get => this.salary;
            private set
            {
                if (value<460)
                {
                    throw new ArgumentException(nameof(salary), "Salary must be at least 460 lv");
                }
                this.Salary = value;

            }
        }

        public override string ToString()
        {
            //return $"{this.FirstName } {this.LastName } is {this.Age } years old.";
            return $"{this.FirstName } {this.LastName } receives {Salary:f2} leva.";
        }

        internal void IncreaseSalary(decimal persentage)
        {
            if (this.Age < 30)
            {
                persentage /= 2;
            }

            this.Salary *= (100 + persentage) / 100;
        }
    }
}
