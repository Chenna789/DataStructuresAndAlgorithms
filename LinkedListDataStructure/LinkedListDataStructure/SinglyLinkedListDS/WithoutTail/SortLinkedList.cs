using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithOutTail
{
    partial class SinglyLinkedListWithOutTail
    {

        public bool IsLinkedListSorted()
        {
            Node current = head;
            while(current.next != null)
            {
                if ((int)current.data > (int)current.next.data)
                    return false;
                current = current.next;
            }
            return true;
        }

        public bool IsLinkedListSortedInDescending()
        {
            Node current = head;
            while(current.next != null)
            {
                if ((int)current.data < (int)current.next.data)
                    return false;
                current = current.next;
            }
            return true;
        }
    }
}
