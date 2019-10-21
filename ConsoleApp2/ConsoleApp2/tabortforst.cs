using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class tabortforst
    {
        public class Node
        {
            public int data;
            public Node next;
        };

        public void removeFirst(Node head)
        {
            if (head == null)
                return null;

            Node temp = head;
            head = head.next;

            return head;
        }
        public push(Node head_ref, int new_data)
        {
            Node new_node = new Node();
            new_node.data = new_data;
            new_node.next = (head_ref);
            (head_ref) = new_node;
            return head_ref;
        }

        public static void Main(String[] args)
        {
            Node head = null;

            head = push(head, 10);
            head = push(head, 11);
            head = push(head, 12);
            head = push(head, 13);
            head = push(head, 14);
            head = push(head, 15);

            head = removeFirstNode(head);
            for (Node temp = head; !=null; temp = temp.next)
                Console.Write(temp.data + "")

        }
    }
}
