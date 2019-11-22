using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS
{
    interface ILinkedList
    {
        object this[int index]
        {
            get;set;
        }
         void AddAfter(object existingNodedata, object newNodedata);
         void Add(int index, object data);
         void AddBefore(object existingNodedata, object newNodedata);
         void AddBeforeWithImporvedComplexity(object existingNodedata, object newNodedata);
         void AddFirst(object data);
         void AddLast(object data);
         Node GetNode(int index);
         Node GetNode(object data);
         object GetNodeData(int index);
         void Remove(object data);
         void RemoveWith_O_1(Node node);
         void Reverse();
         void SetNodeData(int index, object newData);
         void Print();
    }
}
