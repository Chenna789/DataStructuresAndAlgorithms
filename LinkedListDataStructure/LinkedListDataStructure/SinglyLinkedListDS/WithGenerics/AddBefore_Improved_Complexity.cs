using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithGenerics
{
    partial class SinglyLinkedList<AnyType>
    {
        public void AddBeforeWithImporvedComplexity(AnyType existingNodedata, AnyType newNodedata)
        {
            Node<AnyType> newItem = new Node<AnyType>(newNodedata);
            if (head.data.Equals(newNodedata))
            {
                newItem.next = head;
                head = newItem;
                return;
            }
            Node<AnyType> current = head;
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
