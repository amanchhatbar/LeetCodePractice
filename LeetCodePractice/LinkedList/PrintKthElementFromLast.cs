using LeetCodePractice.Domain;

namespace LeetCodePractice.LinkedList;

public class PrintKthElementFromLast
{
    public PrintKthElementFromLast()
    {
        Node value = new Node(10);
        value = new Node(10);
        AddToList addListMethod = new AddToList();
        addListMethod.AddNodeLast(value, 11);
        addListMethod.AddNodeLast(value, 12);
        addListMethod.AddNodeLast(value, 13);
        addListMethod.AddNodeLast(value, 14);
        addListMethod.AddNodeLast(value, 15);
        addListMethod.AddNodeLast(value, 16);
        addListMethod.AddNodeLast(value, 17);
        PrintLinkedList.ConsolePrintLinkedList(value);
        Print(value, 3);
    }
    public int Print(Node? head, int k)
    {
        if (head == null)
        {
            return 0;
        }

        int index = Print(head.Next, k) + 1;
        if (index == k)
        {
            Console.WriteLine($"Kth element is found {head.Data}");
        }

        return index;
    }
}