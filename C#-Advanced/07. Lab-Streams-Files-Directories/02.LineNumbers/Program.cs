using System;
using System.IO;
using System.Linq;

namespace _02.LineNumbers
{
    class Program
    {
        static void Main(string[] args)
        {            
            string inputFilePath = @"../../../text.txt";
            string outputFilePath = @"../../../output.txt";
            string[] textLines = File.ReadAllLines(inputFilePath);

            int lineCounter = 1;
            foreach (string currentLine in textLines)
            {
                int letterCount = currentLine.Count(char.IsLetter);
                int punctuationsCount = currentLine.Count(char.IsPunctuation);

                string text = $"Line {lineCounter}: {currentLine} ({letterCount})({punctuationsCount})";

                if (lineCounter != textLines.Length)
                {
                    text += Environment.NewLine;
                }

                File.AppendAllText(outputFilePath, text);
                lineCounter++;
            }
        }
    }
}
