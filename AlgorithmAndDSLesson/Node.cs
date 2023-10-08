using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAndDSLesson
{
   public class Node
    {
        public int value;
        public Node next;
        public Node(int value) {
            this.value = value;
            this.next = null;
        }
        
   }
    
   public class LinkedList
    {
        public Node Head;
        public Node Tail;
        public LinkedList() {
            this.Head = null;
            this.Tail = null;
        }
        // add element end of list
        public void AddElement(int data)
        {
            Node node = new Node(data);

            if(Head== null)
            {
                Head = node;
            }
            else
            {
                Tail.next = node;
            }
            Tail = node;
            
        }
        // find length of list
        public int findLength()
        {
            var tmp = Head;
            var count = 0;
            while(tmp.next != null) {
                //visit next node
                tmp = tmp.next;
                count++;
            }
            return count;
        }
        // Display all Linked List elements
        public void display()
        {
            if (this.Head != null)
            {
                Console.Write("Linked List Element :");
                var temp = this.Head;
                while (temp != null)
                {
                    Console.Write("  " + temp.value);
                    temp = temp.next;
                }
            }
            else
            {
                Console.WriteLine("Empty Linked list");
            }
        }
    }
}
