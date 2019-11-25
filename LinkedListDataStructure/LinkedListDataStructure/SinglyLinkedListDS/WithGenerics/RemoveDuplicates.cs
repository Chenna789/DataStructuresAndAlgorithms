using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithGenerics
{
    partial class SinglyLinkedList<AnyType>
    {
        public void RemoveDuplicates()
        {
            Node<AnyType> current = head;
            HashSet<AnyType> hashSet = new HashSet<AnyType>();
            while(current != null)
            {
                if (hashSet.Contains(current.data))
                    current.next = current.next.next;
                else
                {
                    hashSet.Add(current.data);
                    current = current.next;
                }
            }
        }
    }
}
