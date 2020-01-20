using System;

namespace _03.StudentSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            StudentSystem studentSystem = new StudentSystem();            
            studentSystem.ParseCommands();            
        }
    }
}