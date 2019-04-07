using System;

namespace _05.Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            bool isValid;
            if (num >= 100 && num <= 200)
            {
                isValid = true;
            }
            else if (num == 0) {
                isValid = true;
            }
            else{
                isValid = false;
            }

            if (!isValid)//if (!isValid) =======  if(isValid == false)
            {
                Console.WriteLine("invalid");
            }
        }
    }
}