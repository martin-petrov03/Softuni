using System;

namespace _16Number_to_Text
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            string one = "one";
            string two = "two";
            string three = "three";
            string four = "four";
            string five = "five";
            string six = "six";
            string seven = "seven";
            string eight = "eight";
            string nine = "nine";

            string number = "";
            int secondNum = num % 10;
            if (num == 0)
            {
                Console.WriteLine("zero");
            }
            else if (num == 1)
            {
                Console.WriteLine(one);
            }
            else if (num == 2)
            {
                Console.WriteLine(two);
            }
            else if (num == 3)
            {
                Console.WriteLine(three);
            }
            else if (num == 4)
            {
                Console.WriteLine(four);
            }
            else if (num == 5)
            {
                Console.WriteLine(five);
            }
            else if (num == 6)
            {
                Console.WriteLine(six);
            }
            else if (num == 7)
            {
                Console.WriteLine(seven);
            }
            else if (num == 8)
            {
                Console.WriteLine(eight);
            }
            else if (num == 9)
            {
                Console.WriteLine(nine);
            }
            else if (num == 100)
            {
                Console.WriteLine("one hundred");
            }
            else if (num == 10)
            {
                Console.WriteLine("ten");
            }
            else if (num == 11)
            {
                Console.WriteLine("eleven");
            }
            else if (num == 12)
            {
                Console.WriteLine("twelve");
            }
            else if (num == 20)
            {
                Console.WriteLine("twenty");
            }
            else if (num == 30)
            {
                Console.WriteLine("thirty");
            }
            else if (num == 40)
            {
                Console.WriteLine("fourty");
            }
            else if (num == 50)
            {
                Console.WriteLine("fifty");
            }
            else if (num == 60)
            {
                Console.WriteLine("sixty");
            }
            else if (num == 70)
            {
                Console.WriteLine("seventy");
            }
            else if (num == 80)
            {
                Console.WriteLine("eighty");
            }
            else if (num == 90)
            {
                Console.WriteLine("ninety");
            }
            else if (num == 13)
            {
                Console.WriteLine("thirteen");
            }
            else if (num == 14)
            {
                Console.WriteLine("fourteen");
            }
            else if (num == 15)
            {
                Console.WriteLine("fifteen");
            }
            else { 
                if (secondNum == 1)
                {
                    number = one;
                }
                else if (secondNum == 2)
                {
                    number = two;
                }
                else if (secondNum == 3)
                {
                    number = three;
                }
                else if (secondNum == 4)
                {
                    number = four;
                }
                else if (secondNum == 5)
                {
                    number = five;
                }
                else if (secondNum == 6)
                {
                    number = six;
                }
                else if (secondNum == 7)
                {
                    number = seven;
                }
                else if (secondNum == 8)
                {
                    number = eight;
                }
                else if (secondNum == 9)
                {
                    number = nine;
                }
            
                for (int i = 16; i <= 19; i++)
                {
                    if (num == i)
                    {
                        Console.WriteLine($"{number}teen");
                    }
                }
                for (int i = 21; i <= 29; i++)
                {
                    if (num == i)
                    {
                        Console.WriteLine($"twenty {number}");
                    }
                }
                for (int i = 31; i <= 39; i++)
                {
                    if (num == i)
                    {
                        Console.WriteLine($"thirty {number}");
                    }
                }
                for (int i = 41; i <= 49; i++)
                {
                    if (num == i)
                    {
                        Console.WriteLine($"forty {number}");
                    }
                }
                for (int i = 51; i <= 59; i++)
                {
                    if (num == i)
                    {
                        Console.WriteLine($"fifty {number}");
                    }
                }
                for (int i = 61; i <= 69; i++)
                {
                    if (num == i)
                    {
                        Console.WriteLine($"sixty {number}");
                    }
                }
                for (int i = 71; i <= 79; i++)
                {
                    if (num == i)
                    {
                        Console.WriteLine($"seventy {number}");
                    }
                }
                for (int i = 81; i <= 89; i++)
                {
                    if (num == i)
                    {
                        Console.WriteLine($"eighty {number}");
                    }
                }
                for (int i = 91; i <= 99; i++)
                {
                    if (num == i)
                    {
                        Console.WriteLine($"ninety {number}");
                    }
                }
            }
            if (num < 0 || num > 100) {
                Console.WriteLine("invalid number");
            }
        }
    }
}