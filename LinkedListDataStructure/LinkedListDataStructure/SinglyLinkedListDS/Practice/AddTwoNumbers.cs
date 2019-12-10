using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDataStructure.SinglyLinkedListDS.Practice
{
    partial class LinkedListPractice
    {
        public Node AddTwoNumbers(Node l1, Node l2)
        {
            Node result = null;
            Node temp = result;
            int carry = 0;
            while (l1 != null && l2 != null)
            {
                bool flag = false;
                int res = Convert.ToInt32(l1.data) + Convert.ToInt32(l2.data) + carry;
                if (res >= 10)
                {
                    res = res % 10;
                    flag = true;
                }
                else
                    carry = 0;
                if (result == null)
                {
                    result = new Node(res);
                    temp = result;
                }
                else
                {
                    temp.next = new Node(res);
                    temp = temp.next;
                }

                if (flag) carry = 1;

                l1 = l1.next;
                l2 = l2.next;
            }
            return result;
        }
    }
}
