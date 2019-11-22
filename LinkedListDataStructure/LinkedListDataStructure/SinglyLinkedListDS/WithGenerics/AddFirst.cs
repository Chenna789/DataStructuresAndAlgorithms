using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithGenerics
{
    partial class SinglyLinkedList<AnyType>
    {
        /// <summary>
        /// Add new node to the first
        /// Read readme.txt 1) Insert at the Start of Linked List
        /// </summary>
        public void AddFirst(AnyType data)
        {
            Node<AnyType> newItem = new Node<AnyType>(data);
            if (head == null)
                tail = newItem;
            newItem.next = head;
            head = newItem; 
            this.Count++;
        }
    }
}
