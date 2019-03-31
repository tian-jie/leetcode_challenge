
public class Solution_00021_MergeTwoLists
{
    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
    {
        var l = new ListNode(0);
        var result = l;
        while (l1 != null && l2 != null)
        {
            if(l1.val <= l2.val)
            {
                l.next = l1;
                l1 = l1.next;
            }
            else
            {
                l.next = l2;
                l2 = l2.next;
            }
            l = l.next;
        }

        if(l1 != null)
        {
            l.next = l1;
        }
        else
        {
            l.next = l2;
        }


        return result.next;
    }

    public ListNode MergeTwoLists1(ListNode l1, ListNode l2)
    {
        if (l1 == null)
        {
            return l2;
        }
        if (l2 == null)
        {
            return l1;
        }

        var left = (l1.val <= l2.val ? l1 : l2);
        var right = (l1.val > l2.val ? l1 : l2);
        var result = left;

        while (left.next != null)
        {
            if(right != null && left.next.val >= right.val)
            {
                var lt = left.next;
                var rt = right.next;
                right.next = left.next;
                left.next = right;
                right = rt;
            }

            left = left.next;
        }
        
        if (right != null)
        {
            left.next = right;
        }

        return result;
    }

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }
    }
}