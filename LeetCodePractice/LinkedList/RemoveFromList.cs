using LeetCodePractice.Domain;

namespace LeetCodePractice.LinkedList;

public class RemoveFromList
{
    public Node? RemoveNodeDataFromList(Node? head, int data)
    {
        if (head == null)
        {
            return head;
        }

        if (head.Data == data)
        {
            head = head.Next;
            return head;
        }
        Node newHead = new Node();
        newHead.Next = head;
        Node current = newHead;

        while (current.Next != null)
        {
            if (current.Next.Data == data)
            {
                current.Next = current.Next.Next;
                break;
            }
            
            current = current.Next;
        }
        return head;
    }
}