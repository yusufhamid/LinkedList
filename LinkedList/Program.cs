/* 1. Implement an algorithm to delete a node in the middle of a single linked list, 
 given only access to that node.
EXAMPLE
Input: the node ‘c’ from the linked list a->b->c->d->e
Result: nothing is returned, but the new linked list looks like a->b->d->e
*/


public static boolean deleteNode(LinkedListNode n)
{
    if (n == null || n.next == null)
    {
        return false; // Failure
    }
    LinkedListNode next = n.next;
    n.data = next.data;
    n.next = next.next;
    return true;
}




/* 2. Implement an algorithm to find the nth to last element of a singly linked list
*/

LinkedListNode nthToLast(LinkedListNode head, int n)
{
    if (head == null || n < 1)
    {
        return null;
    }
    LinkedListNode p1 = head;
    LinkedListNode p2 = head;
    for (int j = 0; j < n - 1; ++j)
    { // skip n-1 steps ahead
        if (p2 == null)
        {
            return null; // not found since list size < n
        }
        p2 = p2.next;
    }
    while (p2.next != null)
    {
        p1 = p1.next;
        p2 = p2.next;
    }
    return p1;
}