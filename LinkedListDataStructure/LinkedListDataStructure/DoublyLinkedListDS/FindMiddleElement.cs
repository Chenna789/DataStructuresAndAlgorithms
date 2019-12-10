using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.DoublyLinkedListDS
{
    partial class DoublyLinkedList<AnyType>
    {
        public Node<AnyType> FindMiddleElement()
        {
            Node<AnyType> current = head;
            for(int i = 0; i < this.Count/2; i++)
                current = current.next;
            return current;
        }

        public Node<AnyType> FindMiddleElementUsingTwoPointers()
        {
            Node<AnyType> slowPointer = head;
            Node<AnyType> fastPointer = head;
            while(fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }
            return slowPointer;
        }
    }
}
