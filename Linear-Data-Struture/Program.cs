using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linear_Data_Struture
{
    internal class Program
    {
        static void Main(string[] args)
        {
            LinkedList linkedlist = new LinkedList();
            Queue queue = new Queue();
            Stack stack = new Stack();
            bool flag = true;
            while (flag)
            {
                Console.WriteLine("\n Plase enter the option");
                Console.WriteLine("Select Option 1");
                Console.WriteLine("Select Option 2");
                Console.WriteLine("Select Option 3");
                Console.WriteLine("Select Option 4");
                Console.WriteLine("Select Option 5");
                Console.WriteLine("Select Option 6");
                Console.WriteLine("Select Option 7");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        linkedlist.Add(56);
                        linkedlist.Add(30);
                        linkedlist.Add(70);
                        linkedlist.Display();
                        break;

                    case 2:
                        linkedlist.AddReverse(70);
                        linkedlist.AddReverse(30);
                        linkedlist.AddReverse(56);
                        break;
                    
                    case 3:
                        queue.Enqueue(10);
                        queue.Enqueue(20);
                        queue.Enqueue(30);
                        queue.Display();
                        break;
                    case 4:
                        queue.Dequeue();
                        break;
                    case 5:
                        queue.Display();
                        break;
                    case 6:
                        stack.Push(10);
                        stack.Push(20);
                        stack.Push(30);
                        stack.Display();
                        break;
                    case 7:
                        stack.Push(10);
                        stack.Push(20);
                        stack.Push(30);
                        stack.Display();
                        stack.Pop(30);
                        stack.Display();
                        break;
                }
            }
        }
    }
}   
