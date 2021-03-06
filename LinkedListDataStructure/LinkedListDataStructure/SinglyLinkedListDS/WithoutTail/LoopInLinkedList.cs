﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithOutTail
{
    partial class SinglyLinkedListWithOutTail
    {
        public void CreateLoop()
        {
            Node current = head;
            while (current.next != null)
                current = current.next;
            current.next = head;
        }
        public bool LoopInLinkedList1()
        {
            Node slowPointer = head;
            Node fastPointer = head;
            while(fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
                if (fastPointer == slowPointer)
                    return true;
            }
            return false;
        }
        public bool LoopInLinkedList2()
        {
            Node current = head;
            HashSet<Node> nodes = new HashSet<Node>();
            while (current != null)
            {
                if (!nodes.Contains(current))
                    nodes.Add(current);
                else
                    return true;
                current = current.next;
            }
            return false;
        }
    }
}
