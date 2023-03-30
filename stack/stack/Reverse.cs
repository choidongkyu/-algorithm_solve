using System.Collections;
using System.Text;

namespace stack
{
    public class Reverse
    {
        static void Main(string[] args)
        {
            StringBuilder sb = new();
            int num = int.Parse(Console.ReadLine());

            for (int i = 0; i < num; ++i)
            {
                string? input = Console.ReadLine();
                ReverseString(input ?? "", sb);
            }

            Console.WriteLine(sb.ToString());

        }
        static private string ReverseString(string s, StringBuilder sb)
        {
            Stack<char> stack = new();
            foreach (char c in s)
            {
                stack.Push(c);
            }

            foreach (char c in stack)
            {
                sb.Append(c);
            }
            sb.Append('\n');
            return (sb.ToString());
        }

    }
}
