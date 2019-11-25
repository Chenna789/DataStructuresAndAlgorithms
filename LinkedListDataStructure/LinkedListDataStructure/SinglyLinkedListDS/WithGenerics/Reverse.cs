using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithGenerics
{
    partial class SinglyLinkedList<AnyType>
    {
        public void Reverse()
        {
            Node<AnyType> current = head;
            Node<AnyType> prev = null;
            while(current != null)
            {
                Node<AnyType> temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            tail = head;
            head = prev;
        }

        public void ReverseUsingRecursion()
        {
            Reverse(this.head);
        }
        private void Reverse(Node<AnyType> current)
        {
            if (current == null) return;
            if(current.next == null)
            {
                head = current;
                return;
            }
            Reverse(current.next);
            current.next.next = current;
            current.next = null;
            tail = current;
        }
    }
}
