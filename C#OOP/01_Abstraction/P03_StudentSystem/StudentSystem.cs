﻿namespace P03_StudentSystem
{
    using System;
    using System.Collections.Generic;

    public class StudentSystem
    {
        public StudentSystem()
        {
            this.Repo = new Dictionary<string, Student>();
        }

        public Dictionary<string, Student> Repo { get; private set; }

        public void ParseCommand()
        {
            string[] args = Console.ReadLine().Split();

            if (args[0] == "Create")
            {
                Create(args);
            }
            else if (args[0] == "Show")
            {
                Show(args);
            }
            else if (args[0] == "Exit")
            {
                Environment.Exit(0);
            }
        }

        private void Show(string[] args)
        {
            var name = args[1];
            if (Repo.ContainsKey(name))
            {
                Console.WriteLine(Repo[name]);
            }
        }

        private void Create(string[] args)
        {
            var name = args[1];
            var age = int.Parse(args[2]);
            var grade = double.Parse(args[3]);
            if (!Repo.ContainsKey(name))
            {
                var student = new Student(name, age, grade);
                Repo[name] = student;
            }
        }
    }


}