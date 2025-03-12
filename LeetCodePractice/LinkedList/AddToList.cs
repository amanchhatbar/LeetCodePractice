using LeetCodePractice.Domain;

namespace LeetCodePractice.LinkedList;

public class AddToList
{
    public void AddNodeLast(Node? head, int data)
    {
        if (head == null)
        {
            return;
        }
        
        Node current = head;

        while (current.Next != null)
        {
            current = current.Next;
        }
        Node newNode = new Node(data);
        current.Next = newNode;
    }
}