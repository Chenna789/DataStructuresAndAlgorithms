﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.DoublyLinkedListDS
{
    partial class DoublyLinkedList<AnyType>
    {
        public void AddBefore(AnyType existingData, AnyType newData)
        {
            Node<AnyType> current = head;
            Node<AnyType> newNode = new Node<AnyType>(newData);
            if (head.data.Equals(existingData))
            {
                newNode.next = head;
                head = newNode;
            }
            else
            {
                for (int i = 0; i < this.Count; i++)
                {
                    if (current.next.data.Equals(existingData))
                        break;
                    current = current.next;
                }
                Node<AnyType> tempNode = current.next;
                current.next = newNode;
                newNode.next = tempNode;
                newNode.prev = current;
                newNode.next.prev = tempNode;
                this.Count++;
            }
        }
    }
}
