using System;

namespace UC1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stack program");
            Stacks stack = new Stacks();
            stack.Push(70);
            stack.Push(30);
            stack.Push(56);
            stack.Display();

        }
    }
}
