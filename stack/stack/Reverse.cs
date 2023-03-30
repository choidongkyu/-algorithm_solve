using System.Text;

namespace stack
{
    public class Reverse
    {
        public static StreamReader sr = new(Console.OpenStandardInput());
        public static StreamWriter sw = new(Console.OpenStandardOutput());
        static void Main(string[] args)
        {
            Stack<char> stack = new();
            int num = int.Parse(sr.ReadLine());
            for (int i = 0; i < num; ++i)
            {
                string[] input = sr.ReadLine().Split(' ');

                foreach(var word in input)
                {
                    ReverseString(word ?? "", stack);
                    sw.Write(' ');
                }
                sw.Write('\n');
            }
            sr.Close();
            sw.Close();
        }
        static private void ReverseString(string s, Stack<char> stack)
        {
            stack.Clear();
            foreach (char c in s)
            {
                stack.Push(c);
            }

            foreach (char c in stack)
            {
                sw.Write(c);
            }
        }

    }
}
