using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS
{
    class SinglyLinkedList
    {
        private Node head;
        public int Count { get; set; }
        /// <summary>
        /// Adding items to linked list from first
        /// for adding data - create a new node 
        /// if head is null then make new node as head
        /// else iterate till the last node and make last.next = newNode
        /// </summary>
        internal void AddLast(object data)
        {
            //Create a new Node
            Node newItem = new Node(data);
            if (head == null)
                head = newItem;
            else
            {
                //will have to get the last node so that we can hook up 
                //our newItem to the last.next
                //we shouldn't change the head - that is why having a
                //temporary node
                Node current = head;
                //iterate thorugh all the nodes till last node
                //We can try to eliminate this loop using tail pointer in another method
                //so that we can reduce time complexity of inserting O(n) to O(1)
                while (current.next != null)
                    current = current.next;
                //Now current will have last node pointer
                current.next = newItem;
            }
            this.Count++;
        }
        /// <summary>
        /// Add new node to the first
        /// Read readme.txt 1) Insert at the Start of Linked List
        /// </summary>
        internal void AddFirst(object data)
        {
            Node newItem = new Node(data);
            newItem.next = head;
            head = newItem;
            this.Count++;
        }

        internal void Add(int index, object data)
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
        /// <summary>
        /// printing all the values by iterating the loop from head node
        /// </summary>
        internal void Print()
        {
            Node current = head;
            while(current != null)
            {
                Console.Write(current.data + " ");
                current = current.next;
            }
        }
    }
}
