using System;
using System.Text;

namespace MyProject;
class Program
{
    static void Main(string[] args)
    {
        Stack<int> stack = new Stack<int>();
        StringBuilder stringBuilder = new();
        var num = int.Parse(Console.ReadLine());
        for (int i = 0; i < num; ++i)
        {
            string? input = Console.ReadLine();
            var token = input.Split(" ");
            switch (token[0])
            {
                case "push":
                    stack.Push(Int32.Parse(token[1]));
                    break;
                case "top":
                    stringBuilder.Append(stack.Any() ? stack.Peek() : -1);
                    stringBuilder.Append('\n');
                    break;
                case "pop":
                    stringBuilder.Append(stack.Any() ? stack.Pop() : -1);
                    stringBuilder.Append('\n');
                    break;
                case "size":
                    stringBuilder.Append(stack.Count);
                    stringBuilder.Append('\n');
                    break;
                case "empty":
                    stringBuilder.Append(stack.Count == 0 ? 1 : 0);
                    stringBuilder.Append('\n');
                    break;
                default:
                    break;
            }
        }
        Console.WriteLine(stringBuilder.ToString());
    }
}
