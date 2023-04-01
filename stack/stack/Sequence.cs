using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritm
{
    public class Sequence
    {
        public static MemoryStream memoryStream = new();
        public static StreamReader sr = new(Console.OpenStandardInput());
        public static StreamReader msr = new(memoryStream);
        public static StreamWriter sw = new(memoryStream);
        static bool success = true;
        static int index = 1;
        static Stack<int> stack = new();
        static void Main(string[] args)
        {
            int num = int.Parse(sr.ReadLine() ?? "0");
            for (int i = 0; i < num; ++i)
            {
                int input = int.Parse(sr.ReadLine() ?? "-1");
                Process(input);
            }
            sw.Flush();
            if (success)
            {
                msr.BaseStream.Seek(0, SeekOrigin.Begin);
                var test = msr.ReadToEnd();
                Console.WriteLine(test);
            }
            else
            {
                Console.WriteLine("NO");
            }
        }

        private static void Process(int input)
        {
            for (; index <= input; ++index)
            {
                stack.Push(index);
                sw.WriteLine("+");
                if (index == input)
                {
                    stack.Pop();
                    sw.WriteLine("-");
                    ++index;
                    return;
                }
            }

            while (true)
            {
                if (stack.Pop() == input)
                {
                    sw.WriteLine("-");
                    return;
                }
                success = false;
                break;
            }
        }
    }
}
