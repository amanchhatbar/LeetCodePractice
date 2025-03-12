using LeetCodePractice.Domain;

namespace LeetCodePractice.LinkedList;

public static class PrintLinkedList
{
    public static void ConsolePrintLinkedList(Node? head)
    {
        if (head == null)
        {
            Console.WriteLine("NULL");
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                Console.Write($"{current.Data}->");
                current = current.Next;
            }
            Console.WriteLine($"{current.Data}->NULL");
        }

    }
}