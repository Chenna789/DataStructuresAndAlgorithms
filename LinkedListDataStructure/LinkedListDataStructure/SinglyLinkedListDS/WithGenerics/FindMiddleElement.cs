using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithGenerics
{
    partial class SinglyLinkedList<AnyType>
    {
        public Node<AnyType> FindMiddleWithOutCount()
        {
            int count = 0;
            Node<AnyType> current = head;
            while(current != null)
            {
                count++;
                current = current.next;
            }
            current = head;
            for(int i = 0; i < count/2; i++)
                current = current.next;
            return current;
        }
        public Node<AnyType> FindMiddleWithCount()
        {
            Node<AnyType> current = head;
            for (int i = 0; i < this.Count / 2; i++)
                current = current.next;
            return current;
        }
        public Node<AnyType> FindMiddleWithTwoPointers()
        {
            Node<AnyType> slowPointer = head;
            Node<AnyType> fastPointer = head;
            while(fastPointer != null && fastPointer.next != null)
            {
                fastPointer = fastPointer.next.next;
                slowPointer = slowPointer.next;
            }
            return slowPointer;
        }
    }
}
