using System;

namespace LeetCodeChallenges._83_RemoveDuplicatesFromSortedList;

public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        if(head == null || head.next == null){
            return head;
        }

        ListNode nodes = head;
        while(nodes.next != null)
        {
            if(nodes.val == nodes.next.val)
            {
                nodes.next = nodes.next.next;
            }
            else
            {
                nodes = nodes.next;
            }
        }
        return head;
    }
}