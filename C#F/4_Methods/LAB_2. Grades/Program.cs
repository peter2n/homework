using System;

namespace LAB_2._Grades
{
    class Program
    {
        static void Main(string[] args)
        {
            //•	2.00 – 2.99 - "Fail"
            //•	3.00 – 3.49 - "Poor"
            //•	3.50 – 4.49 - "Good"
            //•	4.50 – 5.49 - "Very good"
            //•	5.50 – 6.00 - "Excellent"

            double grade = double.Parse(Console.ReadLine());
            string gradeWord;
            string ConvertToWord(double gradeParam)
            {
                if (grade>=2.0 && grade<=2.99)
                {
                    gradeWord = "Failed";
                }
                else if (grade>=3.0 && grade<=3.49)
                {
                    gradeWord = "Poor";
                }
                else if (grade >= 3.5 && grade <= 4.49)
                {
                    gradeWord = "Good";
                }
                else if (grade >= 4.5 && grade <= 5.49)
                {
                    gradeWord = "Very good";
                }
                else if (grade >= 5.5 && grade <= 6.0)
                {
                    gradeWord = "Excellent";
                }
                else
                {
                    gradeWord = "Error";
                }

                return gradeWord;
            }
            Console.WriteLine(ConvertToWord(grade));



        }
    }
}
