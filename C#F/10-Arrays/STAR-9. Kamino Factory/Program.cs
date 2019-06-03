using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace STAR_9.Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            //longest subsequence of ones
            //leftmost starting index, 
            //greater sum

            //  "Best DNA sample {bestSequenceIndex} with sum: {bestSequenceSum}."
            //"{DNA sequence, joined by space}"

            ///////////////////////////////////////////////////////////////
            //a string collects max subsequence of ones for every sequence
            //a string collects start position of that subsequence
            //a string collects sum of every sequence
            ////////////////////////////////////////////////////////////////
            string sumsString = string.Empty; //collects sums of evere sequence in the string, delimited by comma
            string maxString = string.Empty;
            string startPositionString = string.Empty;

            int seqLength = int.Parse(Console.ReadLine());
            int[] genes = new int[seqLength];

            //int startCurrent = 0;
            //int maxCurrent = 0;


            int index = 0; // sequence index
            string input = Console.ReadLine();
            while (input != "Clone them")
            {
                genes = input
                    .Split(new char[] { '!' }, StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                SeqSum();
                SeqRepetitions();


                index++;
            }

            void SeqSum()
            {
                int seqSum = 0;
                for (int k = 0; k < seqLength; k++)
                {
                    seqSum += genes[k];
                }
                sumsString = sumsString + "," + seqSum.ToString();
            }
            void SeqRepetitions()
            {
                int[] repetitionsPerElement = new int[seqLength]; //collects count of repetition after each element of sequence

                for (int l = 0; l < seqLength; l++)
                {
                    int repetitions = 0;
                    for (int m = 0; m < seqLength - l; m++)
                    {

                        if (genes[l] == genes[l+m+1])
                        {
                            repetitions++;
                        }
                        else
                        {
                            break;
                        }
                    }
                    repetitionsPerElement[l] = repetitions + 1;
                    if (genes[l] == 0)
                    {
                        repetitionsPerElement[l] = -1;//elliminate sequences of zeroes
                    }
                }
                int maxCurrent = 0;
                int startPosition = 0;
                for (int j = repetitionsPerElement.Length - 1; j >= 0; j--)//backwards->if multiple max counts, j will get the most left
                {
                    if (repetitionsPerElement[j] >= maxCurrent)
                    {
                        maxCurrent = repetitionsPerElement[j];
                        startPosition = j;
                    }

                }
                maxString = maxString + "," + startPosition;
                startPositionString = startPositionString + "," + startPosition;
            }
            //end SeqRepetitions



        }
    }
}
