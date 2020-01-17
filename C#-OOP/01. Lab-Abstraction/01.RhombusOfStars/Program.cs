using System;
using System.Text;

namespace RhombusOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            StringBuilder sb = new StringBuilder();

            //Top part
            for (int i = 0; i <= n; i++)
            {
                sb.Append(new string(' ', n - i));
                DrawLineOfStars(sb, i);
            }

            //Bottom part
            for (int i = n - 1; i > 0; i--)
            {
                sb.Append(new string(' ', n - i));
                DrawLineOfStars(sb, i);
            }

            Console.WriteLine(sb);
        }

        public static void DrawLineOfStars(StringBuilder sb, int numberOfStars) {
            for (int star = 0; star < numberOfStars; star++)
            {
                sb.Append('*');
                if (star < numberOfStars - 1)
                {
                    sb.Append(' ');
                }
            }
            sb.AppendLine();
        }
    }
}