using System;
using System.Collections.Generic;
using System.Text;

namespace UC1
{
    class Stacks
    {
        public Node top;
        
        public void Push(int data)
        {
            Node newNode = new Node(data);
            if (top == null)
            {
                newNode.next = null;
               
            }
            else
            {
                newNode.next = top;
            }
            top = newNode;
        }

       
        public void Display()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty");
            }
            else
            {
                Node temp = top;
                while (temp != null)
                {
                    Console.Write(temp.data+" ");
                    temp = temp.next;
                }
            }
        }
    }
}
