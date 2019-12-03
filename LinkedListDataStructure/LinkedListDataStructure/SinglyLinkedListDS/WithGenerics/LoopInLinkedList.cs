using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithGenerics
{
    partial class SinglyLinkedList<AnyType>
    {
        public bool LoopInLinkedList1()
        {
            Node<AnyType> slowPointer = head;
            Node<AnyType> fastPointer = head;
            while(slowPointer != null && slowPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next;
                if (slowPointer == fastPointer)
                    return true;
            }
            return false;
        }

        public bool LoopInLinkedList2()
        {
            Node<AnyType> current = head;
            HashSet<Node<AnyType>> hashSet = new HashSet<Node<AnyType>>();
            while(current != null)
            {
                if (hashSet.Contains(current))
                    return true;
                else
                    hashSet.Add(current);
                current = current.next;
            }
            return false;
        }
    }
}
