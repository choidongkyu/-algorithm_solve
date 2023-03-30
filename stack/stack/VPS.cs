using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace stack
{
    public class VPS
    {
        public static StreamReader sr = new(Console.OpenStandardInput());
        public static StreamWriter sw = new(Console.OpenStandardOutput());
        static void Main(string[] args)
        {
            Stack<char> stack = new();
            int num = int.Parse(sr.ReadLine());
            bool success = true;
            for (int i = 0; i < num; ++i)
            {
                success = true;
                stack.Clear();
                string? input = sr.ReadLine();
                foreach (var ps in input)
                {
                    if (ps == '(')
                    {
                        stack.Push(ps);
                    }
                    else if (ps == ')')
                    {
                        if(stack.Count == 0)
                        {
                            success = false;
                            break;
                        }
                        stack.Pop();
                    }
                }

                if (stack.Count == 0 && success)
                {
                    sw.WriteLine("YES");
                }
                else
                {
                    sw.WriteLine("NO");
                }
            }
            sr.Close();
            sw.Close();
        }
    }
}
