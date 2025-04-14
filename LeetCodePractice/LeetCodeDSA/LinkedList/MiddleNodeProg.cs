using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.LinkedList;

public class MiddleNodeProg
{
    public ListNode MiddleNode(ListNode head) {
        if(head == null) return head;
        var slow = head;
        var fast = head;

        while(fast!= null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
        }
        return slow;
    }
}