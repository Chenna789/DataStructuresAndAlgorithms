using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithTail
{
    partial class SinglyLinkedListWithTail
    {
        public void Remove(object data)
        {
            if (head.data == data)
                head = head.next;
            else
            {
                Node current = head;
                while(current.next != null)
                {
                    if (current.next.data.Equals(data))
                    {
                        if (current.next == tail)
                            tail = current;
                        current.next = current.next.next;
                        break;
                    }
                    else
                        current = current.next;
                }
            }
            Count--;
        }
    }
}
