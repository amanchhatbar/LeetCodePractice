using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.LinkedList;

public class ReverseNodePro
{
    public ListNode ReverseList(ListNode head) {
        if(head == null) return head;
        var current = head;
        ListNode prev = null;
        while(current != null){
            var nextNode = current.next;
            current.next = prev;
            prev = current;
            current = nextNode;
        }

        return prev;
    }
}