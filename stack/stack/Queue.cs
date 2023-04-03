
namespace algoritm
{
    public class Queue
    {
        public static StreamReader sr = new(Console.OpenStandardInput());
        public static StreamWriter sw = new(Console.OpenStandardOutput());
        static void Main(string[] args)
        {
            LinkedList<int> linkedList = new();
            int num = int.Parse(sr.ReadLine() ?? "0");
            for (int i = 0; i < num; ++i)
            {
                string[] input = (sr.ReadLine() ?? String.Empty).Split(" ");
                switch (input[0])
                {
                    case "push":
                        linkedList.AddLast(int.Parse(input[1]));
                        break;
                    case "pop":
                        if (linkedList.Count != 0)
                        {
                            sw.WriteLine(linkedList.First());
                            linkedList.RemoveFirst();
                        }
                        else
                        {
                            sw.WriteLine(-1);
                        }
                        break;
                    case "size":
                        sw.WriteLine(linkedList.Count);
                        break;
                    case "empty":
                        sw.WriteLine((linkedList.Count == 0) ? 1 : 0);
                        break;
                    case "front":
                        if (linkedList.Count != 0)
                        {
                            sw.WriteLine(linkedList.First());
                        }
                        else
                        {
                            sw.WriteLine(-1);
                        }
                        break;
                    case "back":
                        if(linkedList.Count != 0)
                        {
                            sw.WriteLine(linkedList.Last());
                        } else
                        {
                            sw.WriteLine(-1);
                        }
                        
                        break;
                }
            }
            sw.Close();
            sr.Close();
        }
    }
}
