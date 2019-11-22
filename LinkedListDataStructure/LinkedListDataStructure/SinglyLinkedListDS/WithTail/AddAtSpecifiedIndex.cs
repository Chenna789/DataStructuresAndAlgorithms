using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithTail
{
    partial class SinglyLinkedListWithTail
    {
        public void Add(int index, object data)
        {
            //If index less than 0 make it default 0
            //If index greate than linked list size then make it to linked list size
            index = (index <= 0) ? 0 : ((index > this.Count) ? this.Count : index);
            Node newItem = new Node(data);
            if (index == 0)
            {
                newItem.next = head;
                head = newItem;
            }
            else if (index == this.Count)
            {
                tail.next = newItem;
                tail = newItem;
            }
            else
            {
                Node current = head;
                for (int i = 0; i < index - 1; i++)
                    current = current.next;
                newItem.next = current.next;
                current.next = newItem;
            }
            this.Count++;
        }
    }
}
