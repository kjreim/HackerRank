namespace HackerRank.LinkedList;

public class SinglyLinkedListNode
{
    public int data;
    public SinglyLinkedListNode? next;

    public SinglyLinkedListNode(int nodeData)
    {
        this.data = nodeData;
        this.next = null;
    }
}

public class MergeLinkedList
{
    // set head to the -1 node keeps the refence to the head of the linked list
    // head.next is the true start of the nodes
    public static SinglyLinkedListNode? Solve(SinglyLinkedListNode? listOne, SinglyLinkedListNode? listTwo)
    {
        SinglyLinkedListNode current = new SinglyLinkedListNode(-1);
        var head = current;
        if (listOne == null) return listTwo;
        if (listTwo == null) return listOne;

        while (listOne != null && listTwo != null)
        {
            if (listOne.data < listTwo.data)
            {
                current.next = listOne;
                listOne = listOne.next;
            }
            else
            {
                current.next = listTwo;
                listTwo = listTwo.next;
            }
            current = current.next;
        }
        
        if (listOne == null) current.next = listTwo;
        else current.next = listOne;

        return head.next;
    }
}