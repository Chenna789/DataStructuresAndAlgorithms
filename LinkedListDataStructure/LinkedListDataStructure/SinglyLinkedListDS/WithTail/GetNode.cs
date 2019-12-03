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

        public Node GetNodeFromTailWithOutCount(int index)
        {
            int count = 0;
            Node current = head;
            while(current != null)
            {
                count++;
                current = current.next;
            }
            current = head;
            for(int i = 0; i < count - index - 1; i++)
                current = current.next;
            return current;
        }

        public Node GetNodeFromTailWithCount(int index)
        {
            Node current = head;
            for (int i = 0; i < this.Count - index - 1; i++)
                current = current.next;
            return current;
        }

        public Node GetNodeFromTailWithTwoPointers(int index)
        {
            Node slowPointer = head;
            Node fastPointer = head;
            int tempIndex = 0;
            while(fastPointer != null)
            {
                if(tempIndex > index)
                    slowPointer = slowPointer.next;
                fastPointer = fastPointer.next;
                tempIndex++;
            }
            return slowPointer;
        }
    }
}
