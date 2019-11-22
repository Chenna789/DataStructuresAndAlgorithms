using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithTail
{
    partial class SinglyLinkedListWithTail
    {
        /// <summary>
        /// Find out the data in the linked list and if it matches 
        /// the existing node data - then add new node before to it
        /// else add a new node at the end
        /// </summary>
        /// <param name="data"></param>

        public void AddBefore(object existingNodedata, object newNodedata)
        {
            Node current = head;
            int index = 0;
            for (int i = 0; i < this.Count; i++)
            {
                if (current.data.Equals(existingNodedata))
                {
                    index = i;
                    break;
                }
                index++;
                current = current.next;
            }
            Add(index, newNodedata);
        }
    }
}
