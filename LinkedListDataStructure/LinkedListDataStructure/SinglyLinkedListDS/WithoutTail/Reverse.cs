using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithOutTail
{
    partial class SinglyLinkedListWithOutTail
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
            head = prev;
        }
    }
}
