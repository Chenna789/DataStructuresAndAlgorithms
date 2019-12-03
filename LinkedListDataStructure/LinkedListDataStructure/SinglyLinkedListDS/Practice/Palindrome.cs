using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.Practice
{
    partial class LinkedListPractice
    {
        private Node Copy(Node head)
        {
            if (head == null)
                return null;
            Node first = new Node(head.data);
            Node current = first;
            head = head.next;
            while(head != null)
            {
                Node newItem = new Node(head.data);
                current.next = newItem;
                current = newItem;
                head = head.next;
            }
            return first;
        }

        private Node Reverse(Node head)
        {
            Node prev = null;
            while(head != null)
            {
                Node temp = head.next;
                head.next = prev;
                prev = head;
                head = temp;
            }
            return prev;
        }

        private bool CompareNodes(Node node1, Node node2)
        {
            //while(node1 != null || node2 != null)
            //{
            //    if (!node1.data.Equals(node2.data))
            //        return false;
            //    node1 = node1.next;
            //    node2 = node2.next;
            //}
            //We have overriden equals method
            return node1.Equals(node2);
        }
        public bool IsPalindrome1(Node head)
        {
            Node current = Copy(head);
            Node reverse = Reverse(current);
            return CompareNodes(head, reverse);
        }
        public bool IsPalindrome2(Node head)
        {
            Stack<object> stack = new Stack<object>();
            Node slowPointer = head;
            Node fastPointer = head;
            while(fastPointer != null && fastPointer.next != null)
            {
                stack.Push(slowPointer.data);
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }
            if (fastPointer != null)
                slowPointer = slowPointer.next;
            while(slowPointer != null)
            {
                if (!stack.Pop().Equals(slowPointer.data))
                    return false;
                slowPointer = slowPointer.next;
            }
            return true;
        }
    }
}
