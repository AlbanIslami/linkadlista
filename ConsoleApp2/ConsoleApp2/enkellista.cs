using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class enkellista
    {
        class Node
        {
            public int value;
            public Node Next;
            public Node(int d) { value = d; Next = null; }
            
            public string data { get; internal set; }
        }
        Node head;
        

        public int New_Data { get; }

        public void AddFirst(int new_data)
        {
            Node new_node = new Node(new_data);

            new_node.Next = head;

            head = new_node;
        }
        public void AddLast(int new_data)
        {
            Node new_node = new Node(new_data);

            if (head == null)
            {
                head = new Node(new_data);
                return;
            }

            new_node.Next = null;

            Node last = head;
            while (last.Next != null)
                last = last.Next;

            last.Next = new_node;
            return;
        }


        static Node RemoveFirst(int new_data, Node head)
        {
            if (head == null)
                return null;

            Node temp = head;
            head = head.Next;

            return head;
        }
        public static Node Push(int new_data, Node head_ref)
        {
            Node new_node = new Node(new_data);
            new_node.value = new_data;
            new_node.Next = (head_ref);
            (head_ref) = new_node;
            return head_ref;
        }

        public static void Main(String[] args)
        {
            Node head_ref = null;

            head_ref = Push(head_ref, 1);
            head_ref = Push(head_ref, 2);
            head_ref = Push(head_ref, 4);
            head_ref = Push(head_ref, 5);
            head_ref = Push(head_ref, 6);

            head_ref = RemoveFirst(head_ref);
            for (Node temp = head_ref; temp != null; temp = temp.Next)
                Console.Write(temp.data + " ");
            head_ref = Removelast(head_ref);
            for (Node temp = head_ref; temp != null; temp = temp.Next)
                Console.Write(temp.data + " ");
        }

        private static Node RemoveFirst(Node head_ref)
        {
            throw new NotImplementedException();
        }

        private static Node Push(Node head_ref, int v)
        {
            throw new NotImplementedException();
        }

        static Node Removelast(Node head)
        {
            if (head == null)
                return null;
            if (head.Next == null)
            {
                return null;
            }
            Node second_last = head;
            while (second_last.Next.Next != null)
                second_last = second_last.Next;

            second_last.Next = null;

            return head;
        }

        static Node push(Node head_ref, int new_data)
        {
            Node new_node = new Node(new_data);
            new_node.value = new_data;
            new_node.Next = (head_ref);
            (head_ref) = new_node;
            return head_ref;
        }
        public void RemoveValue()
        {

        }
        public bool search(int value)
        {
            Node current = head;
            while (current != null)
            {
                if (current.value == value)
                    return true;
                current = current.Next;
            }
            return false;
        }

        public int FindValue(int value)
        {
            Node current = head;

            if (current.value == value)
            {
                return current.value;
            }
            return 0;
        }

        public void PrintList(int value)
        {
            Node current = head;
            current = current.Next;

            
        }




    }
}

