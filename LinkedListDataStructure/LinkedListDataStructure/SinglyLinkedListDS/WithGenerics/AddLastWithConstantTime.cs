using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithGenerics
{
    partial class SinglyLinkedList<AnyType>
    {
        public void AddLast(AnyType data)
        {
            Node<AnyType> newItem = new Node<AnyType>(data);
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
