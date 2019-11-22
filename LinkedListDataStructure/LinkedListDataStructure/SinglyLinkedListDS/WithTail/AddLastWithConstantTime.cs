using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithTail
{
    partial class SinglyLinkedListWithTail
    {
        public void AddLast(object data)
        {
            Node newItem = new Node(data);
            if (head == null)
            {
                head = newItem;
            }
            else
            {
                //we have tail pointer so we can just hook up tail.next = newItem
                tail.next = newItem;
            }
            tail = newItem;
            this.Count++;
        }
    }
}
