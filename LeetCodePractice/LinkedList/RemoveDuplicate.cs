using LeetCodePractice.Domain;

namespace LeetCodePractice.LinkedList;

public class RemoveDuplicate
{
    public Node? RemoveDuplicateNode(Node head)
    {
        if (head == null)
        {
            return null;
        }
        Node current = head;
        
        // Basically it's a nested for-loop where outer one goes one at a time and the inner one goes through all of it against that one.
        while (current != null)
        {
            Node runner = current;
            while (runner.Next != null)
            {
                if (runner.Next.Data == current.Data)
                {
                    runner.Next = runner.Next.Next;
                }
                else
                {
                    runner = runner.Next;
                }
            }
            current = current.Next;
        }
        return head;
    }
}