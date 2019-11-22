using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithOutTail
{
    partial class SinglyLinkedListWithOutTail
    {
        public void AddBeforeWithImporvedComplexity(object existingNodedata, object newNodedata)
        {
            Node newItem = new Node(newNodedata);
            if (head.data == newNodedata)
            {
                newItem.next = head;
                head = newItem;
                return;
            }
            Node current = head;
            for (int i = 0; i < this.Count - 1; i++)
            {
                if (current.next.data.Equals(existingNodedata))
                    break;
                current = current.next;
            }
            newItem.next = current.next;
            current.next = newItem;
            this.Count++;
        }
    }
}
