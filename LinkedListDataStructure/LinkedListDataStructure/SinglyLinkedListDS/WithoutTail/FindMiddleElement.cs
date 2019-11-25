using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithOutTail
{
    partial class SinglyLinkedListWithOutTail
    {
        public Node FindMiddleWithOutCount()
        {
            int count = 0;
            Node current = head;
            while (current != null)
            {
                count++;
                current = current.next;
            }

            current = head;
            for (int i = 0; i < count / 2; i++)
                current = current.next;
            return current;
        }

        public Node FindMiddleWithCount()
        {
            Node current = head;
            for (int i = 0; i < this.Count / 2; i++)
                current = current.next;
            return current;
        }

        public Node FindMiddleWithTwoPointers()
        {
            Node slowPointer = head;
            Node fastPointer = head;
            while (fastPointer != null && fastPointer.next != null)
            {
                slowPointer = slowPointer.next;
                fastPointer = fastPointer.next.next;
            }
            return slowPointer;
        }
    }
}
