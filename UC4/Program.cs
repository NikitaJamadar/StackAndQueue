﻿using System;

namespace UC4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to stack and Queue");
            Queues queue = new Queues();
            queue.Enqueue(56);
            queue.Enqueue(30);
            queue.Enqueue(70);
            Console.WriteLine();

            queue.Dequeue();
            Console.WriteLine();

            queue.Display();
        }
    }
}
