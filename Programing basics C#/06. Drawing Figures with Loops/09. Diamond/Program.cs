using System;

namespace _10.Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int countDash = n;
            
            int height = n / 2;            
            

            int starsCount = 0;
            if (n % 2 == 1)
            {
                starsCount = 1;
            }
            else
            {
                starsCount = 2;
            }                               
            
            Console.WriteLine(new string('-', (n - starsCount) / 2) + new string('*', starsCount) + new string('-', (n - starsCount) / 2));
            int j = starsCount;
            int k = j;
           
            for (int row = 1; row <= height - 1; row++)
            {
                int m = (n - 2 - j) / 2;
                Console.WriteLine(new string('-', m) + '*' + new string('-', j) + '*' + new string('-', m));                
                j += 2;
            }
            //k -= starsCount;
            for (int i = height - 1; i >= 1; i--)                     
            {
              
                Console.WriteLine(new string('-', (n - 2 - k) / 2) + '*' + new string('-', k) + '*' + new string('-', (n - 2 - k) / 2));

                k -= 2;
            }

           // Console.WriteLine(new string('-', (n - starsCount) / 2) + new string('*', starsCount) + new string('-', (n - starsCount) / 2));
        }
    }
}