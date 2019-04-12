using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;

namespace _04.External_Evaluation
{
    class Program
    {
        static void Main(string[] args)
        {
            var countPupil = int.Parse(Console.ReadLine());
            int poorMarks = 0;
            int satisfactoryMarks = 0;
            int goodMarks = 0;
            int veryGoodMarks = 0;
            int excelletMarks = 0;

            for (int i = 0; i < countPupil; i++)
            {
                double currentPoints = double.Parse(Console.ReadLine());            
                  if (currentPoints >= 0 && currentPoints < 22.5)
                  {
                    poorMarks++;
                  }
                  else if (currentPoints >= 22.5 && currentPoints < 40.5)
                  {
                      satisfactoryMarks++;
                  }
                  else if (currentPoints >= 40.5 && currentPoints < 58.5)
                  {
                      goodMarks++;
                  }
                  else if (currentPoints >= 58.5 && currentPoints < 76.5)
                  {
                      veryGoodMarks++;
                  }
                  else if (currentPoints >= 76.5 && currentPoints <= 100)
                  {
                      excelletMarks++;
                  }                 
            }
            //Console.WriteLine(poorMarks);
            //Console.WriteLine(satisfactoryMarks);
            //Console.WriteLine(goodMarks);
            //Console.WriteLine(veryGoodMarks);
            //Console.WriteLine(excelletMarks);
            double poorMarksProzent = (poorMarks * 100.0)/ countPupil;//First MARKS Second * 100 Third COUNTPUPILS
            double satisfactoryMarksProzent = (satisfactoryMarks * 100.0) / countPupil;
            double goodMarksProzent = (goodMarks * 100.0) / countPupil;
            double veryGoodMarksProzent = (veryGoodMarks * 100.0) / countPupil;
            double exelletMarksProzent = (excelletMarks * 100.0) / countPupil;

            Console.WriteLine($"{poorMarksProzent:F2}% poor marks");
            Console.WriteLine($"{satisfactoryMarksProzent:F2}% satisfactory marks");
            Console.WriteLine($"{goodMarksProzent:F2}% good marks");
            Console.WriteLine($"{veryGoodMarksProzent:F2}% very good marks");
            Console.WriteLine($"{exelletMarksProzent:F2}% excellent marks");
        }
    }
}