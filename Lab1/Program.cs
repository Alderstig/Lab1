using System;

namespace Lab1
{
    class Program
    {
        static void Main(string[] args)
        {
            long total = 0;
            string strGreenNums = "";
            string userSequence;

            do
            {
                Console.WriteLine("Input a sequence of letters and numbers:");
                userSequence = Console.ReadLine().Trim();

                if (String.IsNullOrWhiteSpace(userSequence))
                {
                    Console.WriteLine("String cannot be null or empty");
                }
                else
                {
                    break;
                }
            }
            while (true);

            char[] userSequenceInChars = userSequence.ToCharArray();

            Console.WriteLine("");

            for (int i = 0; i < userSequence.Length; i++)
            {
                for (int j = i + 1; j < userSequence.Length; j++)
                {
                    if (!Char.IsDigit(userSequenceInChars[j]))
                    {
                        break;
                    }
                    else if (userSequenceInChars[i] == userSequenceInChars[j])
                    {
                        for (int k = 0; k < userSequence.Length; k++)
                        {
                            if ((k < i) || (k > j))
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                Console.Write(userSequenceInChars[k]);
                            }
                            else
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write(userSequenceInChars[k]);

                                strGreenNums += userSequenceInChars[k];
                            }
                        }

                        long greenNums = Int64.Parse(strGreenNums);
                        total += greenNums;
                        strGreenNums = "";

                        Console.WriteLine("");
                        break;
                    }
                }
            }

            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine($"\nThe green substrings added = {total}");
        }
    }
}
