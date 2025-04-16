using LeetCodePractice.Domain;

namespace LeetCodePractice.LinkedList;

public class RemoveDuplicate
{
    public RemoveDuplicate()
    {
        Node value = new Node(10);
        AddToList addListMethod = new AddToList();
        addListMethod.AddNodeLast(value, 11);
        addListMethod.AddNodeLast(value, 12);
        addListMethod.AddNodeLast(value, 13);
        addListMethod.AddNodeLast(value, 14);
        addListMethod.AddNodeLast(value, 12);
        addListMethod.AddNodeLast(value, 15);
        addListMethod.AddNodeLast(value, 16);
        addListMethod.AddNodeLast(value, 17);
        RemoveDuplicateNode(value);
    }
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