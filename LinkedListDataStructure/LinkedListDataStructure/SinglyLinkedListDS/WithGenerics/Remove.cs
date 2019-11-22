using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithGenerics
{
    partial class SinglyLinkedList<AnyType>
    {
        public void Remove(AnyType data)
        {
            if (head.data.Equals(data))
                head = head.next;
            else
            {
                Node<AnyType> current = head;
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
