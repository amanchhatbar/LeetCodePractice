using LeetCodePractice.Domain;

namespace LeetCodePractice.NeetCodePract.LinkedList;

public class ReverseLinkedList
{
    public Node ReverseList(Node list1, Node list2)
    {
        var result = new Node(0);
        var current= result;
        while(list1 != null && list2 != null)
        {
            if(list1.Data < list2.Data)
            {
                current.Next = list1;
                list1 = list1.Next;
            }
            else{
                current.Next = list2;
                list2 = list2.Next;
            }
            current = current.Next;
        }

        if(list1 != null){
            current.Next = list1;
        }

        if(list2 != null){
            current.Next = list2;
        }

        return result.Next; 
    }
}