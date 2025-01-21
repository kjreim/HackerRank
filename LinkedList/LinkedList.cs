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

public class DoublyLinkedListNode {
    public int data;
    public DoublyLinkedListNode? next;
    public DoublyLinkedListNode? prev;

    public DoublyLinkedListNode(int nodeData) {
        this.data = nodeData;
        this.next = null;
        this.prev = null;
    }
}

public class LinkedList
{
    // set head to the -1 node keeps the refence to the head of the linked list
    // head.next is the true start of the nodes
    public static SinglyLinkedListNode? Merge(SinglyLinkedListNode? listOne, SinglyLinkedListNode? listTwo)
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

    public static SinglyLinkedListNode? Reverse(SinglyLinkedListNode? list)
    {
        if (list == null) return null;
        
        var current = new SinglyLinkedListNode(list.data);
        SinglyLinkedListNode? previous = null;
        
        while (current != null)
        {
            var next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }
        
        return previous;
    }

    public static DoublyLinkedListNode? Reverse(DoublyLinkedListNode? list)
    {
        if (list == null) return null;

        var current = list;
        DoublyLinkedListNode? previous = null;

        while (current != null)
        {
            var next = current.next;
            current.prev = next;
            current.next = previous;
            previous = current;
            current = next;
        }
        
        return previous;
    }
    
    public static SinglyLinkedListNode Insert(SinglyLinkedListNode list, int data, int position)
    {
        if (position == 0)
        {
            var updated = new SinglyLinkedListNode(data)
            {
                next = list
            };
            return updated;
        }
        var current = list;
        var counter = 1;
        // if position is greater than total items add to end of list
        // could check current after loop and throw exception
        while (counter < position && current.next != null)
        {
            current = current.next;
            counter++;
        }
        
        var newNode = new SinglyLinkedListNode(data);
        var next = current.next;
        current.next = newNode;
        newNode.next = next;
        return list;
    }
}