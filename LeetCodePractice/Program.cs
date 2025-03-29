using LeetCodePractice.Domain;
using LeetCodePractice.LinkedList;
using LeetCodePractice.NeetCodePract;
using LeetCodePractice.NeetCodePract.BinarySearch;

public class Program
{
    public static void Main()
    {
        Program program = new Program();
        var testing = new SearchTwoDMatrix();
    }

    public void LinkedListFunctions()
    {
        Node head = new Node(1);

        #region Add to Linked List
        AddToList addListMethod = new AddToList();
        addListMethod.AddNodeLast(head, 2);
        addListMethod.AddNodeLast(head, 3);
        addListMethod.AddNodeLast(head, 4);
        addListMethod.AddNodeLast(head, 5);
        addListMethod.AddNodeLast(head, 6);
        addListMethod.AddNodeLast(head, 7);
        // PrintLinkedList.ConsolePrintLinkedList(head);
        #endregion

        #region Remove element from Linked List
        RemoveFromList removeFromList = new RemoveFromList();
        var modified = removeFromList.RemoveNodeDataFromList(head, 3);
        // PrintLinkedList.ConsolePrintLinkedList(modified);
        modified = removeFromList.RemoveNodeDataFromList(modified, 1);
        // PrintLinkedList.ConsolePrintLinkedList(modified);
        modified = removeFromList.RemoveNodeDataFromList(modified, 6);
        // PrintLinkedList.ConsolePrintLinkedList(modified);
        modified = removeFromList.RemoveNodeDataFromList(modified, 7);
        // PrintLinkedList.ConsolePrintLinkedList(modified);
        #endregion

        #region RemoveDuplicateLinkedListElement
        Node value = new Node(10);
        addListMethod.AddNodeLast(value, 11);
        addListMethod.AddNodeLast(value, 12);
        addListMethod.AddNodeLast(value, 13);
        addListMethod.AddNodeLast(value, 14);
        addListMethod.AddNodeLast(value, 12);
        addListMethod.AddNodeLast(value, 15);
        addListMethod.AddNodeLast(value, 16);
        addListMethod.AddNodeLast(value, 17);
        RemoveDuplicate removeDuplicate = new RemoveDuplicate();
        // PrintLinkedList.ConsolePrintLinkedList(value);
        removeDuplicate.RemoveDuplicateNode(value);
        // PrintLinkedList.ConsolePrintLinkedList(value);
        #endregion

        #region KthElement

        value = new Node(10);
        addListMethod.AddNodeLast(value, 11);
        addListMethod.AddNodeLast(value, 12);
        addListMethod.AddNodeLast(value, 13);
        addListMethod.AddNodeLast(value, 14);
        addListMethod.AddNodeLast(value, 15);
        addListMethod.AddNodeLast(value, 16);
        addListMethod.AddNodeLast(value, 17);
        PrintLinkedList.ConsolePrintLinkedList(value);
        PrintKthElementFromLast PrintKthElementFromLast = new PrintKthElementFromLast();
        PrintKthElementFromLast.Print(value, 3);

        #endregion
        
    }
}