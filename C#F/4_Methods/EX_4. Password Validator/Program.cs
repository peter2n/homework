using System;

namespace EX_4._Password_Validator
{
    class Program
    {
        static void Main(string[] args)
        {
            string pass = Console.ReadLine();

            bool CheckLenght(string passParam)
            {
                if (passParam.Length >= 6 && passParam.Length <= 10)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Password must be between 6 and 10 characters");
                    return false;
                }
            }

            bool CountDigits(string passParam)
            {
                int count = 0;
                for (int i = 0; i < passParam.Length; i++)
                {

                    //if ("0123456789".Contains(passParam[i]))//NO VS is OK, Judge - compilte time error, cannot convert char to string
                    if (passParam[i] >= '0' && passParam[i] <= '9')
                    {
                        count++;
                    }
                }
                if (count >= 2)
                {
                    return true;
                }
                else
                {
                    Console.WriteLine("Password must have at least 2 digits");
                    return false;
                }
            }

            bool ContainsOnlyDigitsAndLetters(string passParam)
            {
                for (int i = 0; i < passParam.Length; i++)
                {
                    if (!((passParam[i] >= 'A' && passParam[i] <= 'Z') || (passParam[i] >= 'a' && passParam[i] <= 'z') || (passParam[i] >= '0' && passParam[i] <= '9')))
                    {
                        Console.WriteLine("Password must consist only of letters and digits");
                        return false;
                    }
                }
                return true;
            }

            bool passCheck = true;
            passCheck = CheckLenght(pass) && passCheck;
            passCheck = ContainsOnlyDigitsAndLetters(pass) && passCheck;
            passCheck = CountDigits(pass) && passCheck;

            if (passCheck)
            {
                Console.WriteLine("Password is valid");
            }
        }
    }
}
