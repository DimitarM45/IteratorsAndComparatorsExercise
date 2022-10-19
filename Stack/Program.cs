using System;
using System.Linq;
using System.Runtime.Intrinsics.X86;

namespace Stack
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] tokens = Console.ReadLine()
                .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);

            Stack<int> stack = new Stack<int>();

            while (tokens[0] != "END")
            {
                switch (tokens[0])
                {
                    case "Push":
                        int[] elementsToPush = tokens
                            .Skip(1)
                            .Select(int.Parse)
                            .ToArray();

                        stack.Push(elementsToPush);
                        break;

                    case "Pop":
                        stack.Pop();
                        break;
                }

                tokens = Console.ReadLine()
                    .Split(new char[] { ',', ' ' }, StringSplitOptions.RemoveEmptyEntries);
            }

            for (int i = 1; i <= 2; i++)
            {
                foreach (var item in stack)
                    Console.WriteLine(item);
            }
        }
    }
}
