using System;
using System.IO;
using System.Linq;

namespace _01.EvenLines
{
    class Program
    {
        static void Main(string[] args)
        {
            string textFilePath = @"../../../text.txt";

            using (StreamReader streamReader = new StreamReader(textFilePath))
            {
                int counter = 0;
                string test = streamReader.ReadLine();
                while (test != null)
                {

                    if (counter % 2 == 0)
                    {
                        string replacedWords = ReplaceSpecialCharacter(test);
                        string reversedWords = ReverseWord(replacedWords);
                        Console.WriteLine(reversedWords);
                    }

                    test = streamReader.ReadLine();
                    counter++;
                }                
            }
        }

        private static string ReverseWord(string replacedSymbols)
        {
            return String.Join(" ", replacedSymbols.Split().Reverse());
        }

        private static string ReplaceSpecialCharacter(string currentLine)
        {
            return currentLine
                .Replace(oldValue: "-", newValue: "@")
                .Replace(oldValue: ",", newValue: "@")
                .Replace(oldValue: ".", newValue: "@")
                .Replace(oldValue: "!", newValue: "@")
                .Replace(oldValue: "?", newValue: "@");
        }
    }
}