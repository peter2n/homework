using System;
using System.Collections.Generic;
using System.Text;

namespace EX_9_Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder text = new StringBuilder();
            Stack<string[]> commandsToUndo = new Stack<string[]>();
            Stack<string> removedElements = new Stack<string>();
            for (int i = 0; i < n; i++)
            {

                string[] command = Console.ReadLine().Split(' ',StringSplitOptions.RemoveEmptyEntries );
                int commandType = int.Parse(command[0]);
                switch (commandType)
                {
                    case 1:
                        text.Append(command[1]);
                        commandsToUndo.Push(command);
                        break;
                    case 2:
                        Stack<char> stack = new Stack<char>(text.ToString());
                        int number = int.Parse(command[1]);
                        for (int j = 0; j < number; j++)
                        {
                            removedElements.Push(stack.Peek().ToString());
                            stack.Pop();

                        }
                        text = new StringBuilder();
                        if (stack.Count > 0)
                        {
                            text.Append(string.Join("", stack));
                        }
                        commandsToUndo.Push(command);
                        break;
                    case 3:
                        int index = int.Parse(command[1]);
                        Console.WriteLine((text.ToString())[index - 1]);
                        break;
                    case 4:
                        string[] commandToUndo = commandsToUndo.Pop();
                        if (int.Parse(commandToUndo[0]) == 1)
                        {
                            int expressionLenght = commandToUndo[1].Length;
                            text.Remove((text.Length - expressionLenght), expressionLenght);
                        }
                        else if (int.Parse(commandToUndo[0]) == 2)
                        {
                            for (int k = 0; k < int.Parse(commandToUndo[1]); k++)
                            {
                                text.Append(string.Join("", removedElements.Peek()));
                            }
                        }
                        break;
                }
            }
        }
    }
}
