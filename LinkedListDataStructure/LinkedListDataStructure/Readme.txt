Linked List
------------------------
A LinkedList is a linear data structure which stores element in the non-contiguous location.
The elements in a linked list are linked with each other using pointers. 
Or in other words, LinkedList consists of nodes where each node contains a data field 
and a reference(link) to the next node in the list.
1) Singly Linked List - one node has refence to next node
2) Doubly Linked List - one node has reference of previous and reference to next node
3) Circular Linked List - same like doubly linked list but tail node will have circular
	reference to head node.

Note: Imagine Linked List as a normal chain ()->()->()


Insertion:
-----------
1) Insert at the Start of Linked List
------------------------------------
Imagine this as a normal chain  where you have a chain and you want to insert a new link 
on the starting, what you will do?
	Get a new link and append to the existing chain starting(head)
	newItem.next = head;
	head = newItem;//newItem will become head now
Since we have the head node pointer we are just linking new node to it.
This has the complexity of O(1) - Constant time

2) Insert on the Last Node
-------------------------------
How do you insert a new link to the end of the chain?
	i) Find the Last node(iterate till last node) and make lastnode.next = newItem - O(n)
	ii) If we have last node pointer(tail) - then just link tail.next = newItem - O(1)

3) Insert at the specific index
--------------------------------
How do you insert a new link in the middle(or specified index) in the chain?
	i) We will have to get the node at index -1 and make newNode.next = indexNode.next 
	and indexNode.next = newNode; We can track the linked list
	size using count so that when we are inserting we will increment, we can easily track down
	number of elements in linked list. To get the node at index - 1, repeat the loop till count-1
	This will become the complexy O(n), if we have the tail pointer then the complexity
	will become O(n-1) eventually O(n)