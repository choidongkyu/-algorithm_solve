using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace algoritm
{
    public class Baekjoon_1436
    {
        public static StreamReader sr = new(Console.OpenStandardInput());
        public static StreamWriter sw = new(Console.OpenStandardOutput());
        static void Main(string[] args)
        {
            int num = int.Parse(sr.ReadLine() ?? "0");
            int result = 665;
            int count = 0;
            while (true)
            {
                if (IsApocalypse(result))
                {
                    count++;
                    if (count == num)
                    {
                        break;
                    }
                }
                result++;
            }
            sw.WriteLine(result);
            sw.Close();
        }

        static bool IsApocalypse(int num)
        {
            int temp = num;
            while(temp != 0)
            {
                if((temp % 1000) == 666)
                {
                    return true;
                }
                temp /= 10;
            }

            return false;
        }
    }
}
