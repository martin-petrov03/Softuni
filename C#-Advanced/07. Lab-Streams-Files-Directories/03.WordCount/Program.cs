using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace _03.WordCount
{
    class Program
    {
        static void Main(string[] args)
        {
            string inputTextFilePath = @"../../../text.txt";
            string inputWordsFilePath = @"../../../words.txt";
            string outputFilePath = @"../../../actualResult.txt";
            string expectedFilePath = @"../../../expectedResult.txt";

            string[] textLines = File.ReadAllLines(inputTextFilePath);
            string[] words = File.ReadAllLines(inputWordsFilePath);

            var wordsInfo = new Dictionary<string, int>();
            foreach (string word in words)
            {
                string currentWordToLowerCase = word.ToLower();
                if (!wordsInfo.ContainsKey(currentWordToLowerCase))
                {
                    wordsInfo[currentWordToLowerCase] = 0;
                }                
            }

            foreach (string textLine in textLines)
            {
                string[] currentLineWords = textLine
                    .Split(' ', '-', ',', '.', '!', '?', '\'', ':', ';');

                foreach (string currentWord in currentLineWords)
                {
                    string currentLineWord = currentWord.ToLower();
                    if (wordsInfo.ContainsKey(currentLineWord.ToLower()))
                    {
                        wordsInfo[currentLineWord]++;
                    }
                }
            }

            int counter = 0;
            foreach (var (key, value) in wordsInfo)
            {
                string output = $"{key} - {value}";
                if (counter < wordsInfo.Count - 1)
                {
                    output += Environment.NewLine;
                }

                File.AppendAllText(outputFilePath, output);
                counter++;
            }

            counter = 0;
            foreach (var (key, value) in wordsInfo.OrderByDescending(x => x.Value))
            {
                string output = $"{key} - {value}";
                if (counter < wordsInfo.Count - 1)
                {
                    output += Environment.NewLine;
                }

                File.AppendAllText(expectedFilePath, output);
                counter++;
            }
        }
    }
}