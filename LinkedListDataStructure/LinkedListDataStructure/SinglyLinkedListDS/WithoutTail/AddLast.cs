using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithOutTail
{
    partial class SinglyLinkedListWithOutTail
    {
        /// <summary>
        /// Adding items to linked list from first
        /// for adding data - create a new node 
        /// if head is null then make new node as head
        /// else iterate till the last node and make last.next = newNode
        /// </summary>
        public void AddLast(object data)
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
    }
}
