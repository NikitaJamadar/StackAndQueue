using System;
using System.Collections.Generic;
using System.Text;

namespace UC2
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
                    Console.WriteLine(temp.data);
                    temp = temp.next;
                }
            }
        }
        public void PeakAndPop()
        {
            while (top != null)
            {
                Peak();
                Pop();
            }
        }
        public void Peak()
        {
            if (top == null)
            {
                Console.WriteLine("Stack is empty.");
            }
            else
            {
                Console.WriteLine("The peak value in stack:"+top.data);
            }
        }
        
        public void Pop()
        {
            if (top == null)
            {
                Console.WriteLine("The stack is empty");
            }
            else
            {
                Console.WriteLine(top.data+" popped out in stack" );
                top = top.next;
            }
        }
       
  
    }
}
