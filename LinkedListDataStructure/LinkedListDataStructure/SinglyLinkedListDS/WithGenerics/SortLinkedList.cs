using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithGenerics
{
    partial class SinglyLinkedList<AnyType>
    {
        public bool IsLinkedListSorted()
        {
            Node<AnyType> current = head;
            while(current.next != null)
            {
                if (Comparer<AnyType>.Default.Compare(current.data, current.next.data) > 0)
                    return false;
                current = current.next;
            }
            return true;
        }

        public bool IsLinkSortedInDescending()
        {
            Node<AnyType> current = head;
            while(current.next != null)
            {
                if (Comparer<AnyType>.Default.Compare(current.data, current.next.data) < 0)
                    return false;
                current = current.next;
            }
            return true;
        }
    }
}
