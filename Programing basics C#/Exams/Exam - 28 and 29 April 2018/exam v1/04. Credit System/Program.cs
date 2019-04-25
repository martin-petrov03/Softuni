using System;
using System.Linq;

namespace _04._Credit_System
{
    class Program
    {
        static void Main(string[] args)
        {
            int kursesCount = int.Parse(Console.ReadLine());

            double totalCredits = 0;
            int totalNotesSum = 0;

            int i = 1;
            while (true) { 
            //for (int i = 1; i <= kursesCount + 1; i++)            
                if (i <= kursesCount)
                {
                    string input = Console.ReadLine();

                    char note = input.Last();
                    int currentNote = int.Parse(note.ToString());
                    //input.Remove(input[input.Length - 1]);                   
                    totalNotesSum += currentNote;

                    double maxCredits = double.Parse(input.TrimEnd(note));
                    //int maxCredits = int.Parse(input);                    

                    if (currentNote == 3)
                    {
                        maxCredits = maxCredits / 2;
                    }
                    else if (currentNote == 4)
                    {
                        maxCredits = maxCredits * 0.7;
                    }
                    else if (currentNote == 5)
                    {
                        maxCredits = maxCredits * 0.85;
                    }
                    else if (currentNote == 2) {
                        maxCredits = 0;
                    }
                   // else if (currentNote == 6)
                   // {
                   //     maxCredits = maxCredits;
                   // }
                    totalCredits += maxCredits;
                }else{
                    break;
                }
                i++;
            }
            double averageNote = (double)totalNotesSum / kursesCount;
            Console.WriteLine($"{totalCredits:F2}");
            Console.WriteLine($"{averageNote:F2}");
        }
    }
}
