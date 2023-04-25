using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritm
{
    public class Baekjoon_2231
    {
        public static StreamReader sr = new(Console.OpenStandardInput());
        public static StreamWriter sw = new(Console.OpenStandardOutput());
        static void Main(string[] args)
        {
            int num = int.Parse(sr.ReadLine() ?? "0");
            int result = 0;
            for(int i = 0; i < 10000000; ++i)
            {
                if(GetSolution(i) == num)
                {
                    result = i;
                    break;
                }
            }
            sw.WriteLine(result);
            sw.Close();
        }

        private static int GetSolution(int num)
        {
            int result = num;
            int temp = num;
            while(temp != 0)
            {
                result += temp % 10;
                temp /= 10;
            }
            return result;
        }
    }
}
