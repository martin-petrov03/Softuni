using System;

namespace _6._Password_Generator
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());

            string bigChar = Console.ReadLine().ToUpper();
            bigChar.ToCharArray();
            char bigChar1 = bigChar[0];
            string smallChar = Console.ReadLine().ToLower();
            smallChar.ToCharArray();
            char smallChar1 = smallChar[0];

            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int num4 = int.Parse(Console.ReadLine());

            decimal position = decimal.Parse(Console.ReadLine());
            decimal counter = 0;
            string result = string.Empty;  
            
            for (int a = 1; a <= num1; a++)
            {
                for (char b = 'A'; b <= bigChar1; b++)
                {
                    for (char c = 'a'; c <= smallChar1; c++)
                    {
                        for (int d = 1; d <= num2; d++)
                        {
                            for (int e = 1; e <= num3; e++)
                            {
                                for (int i = 1; i <= num4; i++)
                                {                                   
                                    counter++;
                                    if (counter == position)
                                    {
                                        result = $"{a}{b}{c}{d}{e}{i}";
                                        break;
                                    }
                                    if (counter > position)
                                    {
                                        break;
                                    }
                                }                            
                            }
                        }
                    }
                }
            }

            if (result.Length == 0)
            {
                Console.WriteLine("No password on this position");
            }
            else {
                Console.WriteLine(result);
            }
        }
    }
}
