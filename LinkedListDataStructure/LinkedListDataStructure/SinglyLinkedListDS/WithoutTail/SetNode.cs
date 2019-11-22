using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithOutTail
{
    partial class SinglyLinkedListWithOutTail
    {
        public void SetNodeData(int index, object newData)
        {
            Node current = head;
            for(int i = 0; i < index && i < this.Count; i++)
                current = current.next;
            current.data = newData;
        }
    }
}
