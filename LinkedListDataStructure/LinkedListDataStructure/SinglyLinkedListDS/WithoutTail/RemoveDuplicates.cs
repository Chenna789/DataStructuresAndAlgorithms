using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithOutTail
{
    partial class SinglyLinkedListWithOutTail
    {
        public void RemoveDuplicates()
        {
            Node current = head;
            HashSet<object> hashSet = new HashSet<object>();
            while(current != null)
            {
                if (hashSet.Contains(current.data))
                    current.next = current.next.next;
                else
                {
                    hashSet.Add(current.data);
                    current = current.next;
                }
            }
        }
    }
}
