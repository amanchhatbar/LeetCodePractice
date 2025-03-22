using LeetCodePractice.Domain;

namespace LeetCodePractice.BinaryTree;

public class CreateBT
{
    public Node BinaryTree = new Node(); 
    public CreateBT()
    {
        BinaryTree = CreateBinaryTree([1, 2, 3, 4, 5, 6, 7, 8, 9, 10]);
    }
    public Node CreateBinaryTree(int[] input)
    {
        Node tree = new Node(input[0]);
        Queue<Node> queueData = new Queue<Node>();
        int i = 1;
        queueData.Enqueue(tree);
        while (i < input.Length)
        {
            var unqueuedValue = queueData.Dequeue();
            if (unqueuedValue.Left == null && i < input.Length)
            {
                unqueuedValue.Left = new Node(input[i]);
                queueData.Enqueue(unqueuedValue.Left);
                i++;
            }

            if (unqueuedValue.Right == null && i < input.Length)
            {
                unqueuedValue.Right = new Node(input[i]);
                queueData.Enqueue(unqueuedValue.Right);
                i++;
            }
        }

        return tree;
    }
}