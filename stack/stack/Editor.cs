using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace algoritm
{
    public class Editor
    {
        public static StreamReader consoleStreamReader = new(Console.OpenStandardInput());
        public static StreamWriter consoleStreamWriter = new(Console.OpenStandardOutput());
        static void Main(string[] args)
        {
            Stack<char> tempStack = new();
            Stack<char> rigthStack = new();
            Stack<char> leftStack = new();

            string? input = consoleStreamReader.ReadLine();
            foreach(var data in input ?? String.Empty.Reverse() ) {
                tempStack.Push(data);
            }
            
            int num = int.Parse(consoleStreamReader.ReadLine() ?? "0");
            for (int i = 0; i < num; ++i)
            {
                string[]? command = consoleStreamReader.ReadLine()?.Split(" ");

                if (command == null) return;

                switch (command[0])
                {
                    case "L":
                        if (tempStack.TryPop(out var right))
                        {
                            rigthStack.Push(right);
                        }
                        
                        break;
                    case "D":
                        if (rigthStack.TryPop(out var left))
                        {
                            tempStack.Push(left);
                        }
                        break;
                    case "B":
                        if(tempStack.Count is not 0)
                        {
                            tempStack.Pop();
                        }
                        break;
                    case "P":
                        tempStack.Push(char.Parse(command[1]));
                        break;
                    default:
                        break;
                }
            }
            var size = tempStack.Count;
            for (int i = 0; i < size; ++i)
            {
                leftStack.Push(tempStack.Pop());
            }

            for (int i = 0; i < size; ++i)
            {
                consoleStreamWriter.Write(leftStack.Pop());
            }
            //for (int i = tempStack.Count - 1; i >= 0; --i)
            //{
            //    consoleStreamWriter.Write(tempStack.ElementAt(i));
            //}
            size = rigthStack.Count;
            for (int i = 0; i < size; ++i)
            {
                consoleStreamWriter.Write(rigthStack.Pop());
            }

            consoleStreamWriter.Close();
            consoleStreamReader.Close();
        }
    }
}
