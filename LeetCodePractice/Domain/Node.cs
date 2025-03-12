namespace LeetCodePractice.Domain;

public class Node
{
    public int Data { get; set; }
    public Node? Left { get; set; }
    public Node? Right { get; set; }
    public Node? Next { get; set; }

    public Node(int data = 0, Node? left = null, Node? right = null, Node? next = null)
    {
        Data = data;
        Left = left;
        Right = right;
        Next = next;
    }
}