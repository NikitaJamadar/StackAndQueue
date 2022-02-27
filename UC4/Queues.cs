using System;
using System.Collections.Generic;
using System.Text;

namespace UC4
{
    class Queues
    {
        public Node top;

        public void Enqueue(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                top = newNode;
            }
            else
            {
                Node temp = top;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = newNode;
            }
        }
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Queue is empty");
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.WriteLine(temp.data+" ");
                    temp = temp.next;
                }
            }
        }
        public void Dequeue()
        {
            if (top == null)
            {
                Console.WriteLine("Queue is already empty");
            }
            else
            {
                while (top!= null)
                {
                    Console.WriteLine(top.data + " is  removed from Queue");
                    top = top.next;
                }
               
            }
        }
    }
}
