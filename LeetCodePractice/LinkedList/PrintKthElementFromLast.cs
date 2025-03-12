using LeetCodePractice.Domain;

namespace LeetCodePractice.LinkedList;

public class PrintKthElementFromLast
{
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