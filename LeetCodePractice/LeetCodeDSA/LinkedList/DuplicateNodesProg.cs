using LeetCodePractice.Domain;

namespace LeetCodePractice.LeetCodeDSA.LinkedList;

public class DuplicateNodesProg
{
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null) return head;
        var current = head;
        
        while(current != null && current.next != null){
            while(current.next != null && current.val == current.next.val){
                current.next = current.next.next;
            }
            current = current.next;
        }
        return head;
    }
}