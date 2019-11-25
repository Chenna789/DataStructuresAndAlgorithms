using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithTail
{
    partial class SinglyLinkedListWithTail
    {
        public void Reverse()
        {
            Node current = head;
            Node prev = null;
            while(current != null)
            {
                Node temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            tail = head;
            head = prev;
        }

        public void Reverse(Node current)
        {
            if (current == null) return;
            if (current.next == null)
            {
                head = current;
                return;
            }
            Reverse(current.next);
            current.next.next = current;
            current.next = null;
            tail = current;
        }

        public void ReverseUsingRecursion()
        {
            Reverse(this.head);
        }
    }
}
