using LeetCodePractice.Domain;

namespace LeetCodePractice.LinkedList;

public class DeepCopy
{
    public Node CopyRandomList(Node head) 
    {
        if (head == null) return null;

        // Dictionary to map original nodes to copied nodes
        Dictionary<Node, Node> map = new Dictionary<Node, Node>();

        // First pass: Copy all nodes and store them in the map
        Node current = head;
        while (current != null) {
            map[current] = new Node(current.Data);
            current = current.Next;
        }

        // Second pass: Assign next and random pointers
        current = head;
        while (current != null) {
            map[current].Next = current.Next != null ? map[current.Next] : null;
            map[current].Random = current.Random != null ? map[current.Random] : null;
            current = current.Next;
        }

        var testing = map[head];
        return map[head]; // Return the copied head node
    }
}