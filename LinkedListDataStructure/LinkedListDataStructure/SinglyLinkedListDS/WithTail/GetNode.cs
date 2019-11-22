using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.WithTail
{
    partial class SinglyLinkedListWithTail
    {
        public Node GetNode(int index)
        {
            Node current = head;
            for(int i = 0; i < index && i < this.Count; i++)
                current = current.next;
            return current;
        }

        public Node GetNode(object data)
        {
            Node current = head;
            for(int i = 0; i < this.Count; i++)
            {
                if (current.data.Equals(data))
                    return current;
                current = current.next;
            }
            return null;
        }

        public object GetNodeData(int index)
        {
            return GetNode(index).data;
        }
    }
}
