using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritm
{
    public class Tiling
    {
        public static StreamReader sr = new(Console.OpenStandardInput());
        public static StreamWriter sw = new(Console.OpenStandardOutput());
        static void Main(string[] args)
        {
            int num = int.Parse(sr.ReadLine() ?? "0");
            int[] memo = new int[num + 2];
            memo[1] = 1;
            memo[2] = 2;
            for(int i = 3; i <= num; ++i)
            {
                memo[i] = (memo[i - 1] + memo[i - 2]) % 10007;
            }

            sw.WriteLine(memo[num]);
            sw.Close();
        }
    }
}
