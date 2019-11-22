using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithOutTail
{
    partial class SinglyLinkedListWithOutTail
    {
        public void Remove(object data)
        {
            if (head.data == data)
                head = head.next;
            else
            {
                Node current = head;
                while(current != null)
                {
                    if (current.next.data.Equals(data))
                    {
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
