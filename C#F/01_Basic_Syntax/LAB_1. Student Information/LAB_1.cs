using System;

namespace LAB_1._Student_Information
{
    class LAB_1
    {
        static void Main(string[] args)
        {
            //"Name: {student name}, Age: {student age}, Grade: {student grade}".
            string name = Console.ReadLine();
            int age = int.Parse(Console.ReadLine());
            double grade = double.Parse(Console.ReadLine());

            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade:f2}");
            Console.WriteLine($"Name: {name}, Age: {age}, Grade: {grade.ToString(format: "F2")}");
            Console.WriteLine("Name: {0}, Age: {1}, Grade: {2:f2}",name,age,grade);

        }
    }
}
