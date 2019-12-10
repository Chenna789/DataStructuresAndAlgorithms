using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.DoublyLinkedListDS
{
    partial class DoublyLinkedList<AnyType>
    {
        internal void Add(int index, AnyType data)
        {
            index = index <= 0 ? 0 : ((index > Count) ? Count : index);
            Node<AnyType> current = head;
            Node<AnyType> newNode = new Node<AnyType>(data);
            if (index == 0)
            {
                newNode.next = head;
                head.prev = newNode;
                head = newNode;
            }
            else if(index == this.Count)
            {
                tail.next = newNode;
                newNode.prev = tail;
                tail = newNode;
            }
            else
            {
                for (int i = 0; i < index - 1; i++)
                    current = current.next;
                Node<AnyType> temp = current.next;
                current.next = newNode;
                newNode.prev = current;
                newNode.next = temp;
                current.next.next.prev = newNode;
            }
            this.Count++;
        }
    }
}
