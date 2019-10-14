using System;
using System.Collections.Generic;

namespace _07.SoftUni_Party
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> vips = new HashSet<string>();
            HashSet<string> otherPeople = new HashSet<string>();

            string line = Console.ReadLine();            
            while (line != "PARTY")
            {
                if (Char.IsDigit(line[0]))
                {
                    vips.Add(line);
                }
                else
                {
                    otherPeople.Add(line);
                }

                line = Console.ReadLine();
            }

            line = Console.ReadLine();            
            while (line != "END")
            {
                if (Char.IsDigit(line[0]))
                {
                    vips.Remove(line);
                }
                else
                {
                    otherPeople.Remove(line);
                }

                line = Console.ReadLine();
            }
           
            Console.WriteLine(vips.Count + otherPeople.Count);
            foreach (string currentVip in vips)
            {
                Console.WriteLine(currentVip);
            }
            foreach (string person in otherPeople)
            {                
                Console.WriteLine(person);
            }           
        }
    }
}