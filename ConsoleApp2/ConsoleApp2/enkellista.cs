using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class enkellista
    {
        public class Node
        {
            public int value;
            public Node next;
            public Node(int d) {value = d; next = null; }
        }
        Node head;


        public void AddFirst(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.next = head;

            head = new_node;
        }
        public void AddLast(int new_data)
        {
            Node new_node = new Node(new_data);

            if(head == null)
            {
                head = new Node(new_data);
                return;
            }

            new_node.next = null;

            Node last = head;
            while (last.next != null)
                last = last.next;

            last.next = new_node;
            return;
        }
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
            for (Node temp = head; != null; temp = temp.next)
                Console.Write(temp.data + "")

        }

        private static Node push(Node head, int v)
        {
            throw new NotImplementedException();
        }

        public void RemoveLast()
        {

        }
        public void RemoveValue()
        {

        }
        public void FindValue()
        {

        }
        public void PrintList()
        {

        }
    }
}
