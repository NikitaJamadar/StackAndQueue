using System;

namespace UC2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wecome to stack and Queue");
            Stacks stack = new Stacks();
            stack.Push(70);
            stack.Push(30);
            stack.Push(50);
            Console.WriteLine();

            stack.Display();

            stack.PeakAndPop();

            Console.WriteLine();
            stack.Display();
        }
    }
}
