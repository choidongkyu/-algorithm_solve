using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritm
{
    public class Sequence
    {
        public static StreamReader sr = new(Console.OpenStandardInput());
        public static StreamWriter sw = new(Console.OpenStandardOutput());
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
            
            sw.Close();
        }

        private static void Process(int input) //index : 5, input 3, lastnum : 4
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
        }
    }
}
