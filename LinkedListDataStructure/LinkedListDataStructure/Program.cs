using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LinkedListDataStructure.SinglyLinkedListDS.WithTail;
using LinkedListDataStructure.SinglyLinkedListDS.WithOutTail;
using LinkedListDataStructure.SinglyLinkedListDS.WithGenerics;
using LinkedListDataStructure.SinglyLinkedListDS;

namespace LinkedListDataStructure
{
    class Program
    {
        static void Main(string[] args)
        {
            ILinkedList[] singlyLinkedLists = new ILinkedList[]{new SinglyLinkedListWithTail(),
                                                                new SinglyLinkedListWithOutTail() };

            foreach(ILinkedList linkedList in singlyLinkedLists)
            {
                TestLinkedList.Test(linkedList);
            }

        }
    }
}
