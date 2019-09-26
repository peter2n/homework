using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace EX_6_Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] songsArray = Console
                .ReadLine()
                .Split(", ", StringSplitOptions.RemoveEmptyEntries)
                .Select(x => x)
                .ToArray();

            Queue<string> songsQueue = new Queue<string>(songsArray);

            while (songsQueue.Count>0)
            {
                string[] line = Console
                    .ReadLine()
                    .Split(" ",2, StringSplitOptions.RemoveEmptyEntries)
                    .Select(x => x)
                    .ToArray();

                string command = line[0].ToLower();

                switch (command)
                {
                    case "play":
                        songsQueue.Dequeue();
                        break;

                    case "add":
                        if (songsQueue.Contains(line[1]))
                        {
                            Console.WriteLine($"{line[1]} is already contained!");
                        }
                        else
                        {
                            songsQueue.Enqueue(line[1]);
                        }
                        break;

                    case "show":
                        string[] showSongsQueue = new string[songsQueue.Count];
                        songsQueue.CopyTo(showSongsQueue, 0);
                        Console.WriteLine(string.Join(", ",showSongsQueue ));
                        break;

                    default:
                        break;
                }
            }

            Console.WriteLine("No more songs!");
        }
    }
}
