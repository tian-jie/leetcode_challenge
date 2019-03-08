
public class Solution00021
{
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

        var min = (l1.val <= l2.val ? l1 : l2);
        var max = (l1.val > l2.val ? l1 : l2);

        var ll = new ListNode(min.val);
        var result = ll;
        min = min.next;
        while (min != null)
        {
            while (max != null && max.val <= min.val)
            {
                ll.next = new ListNode(max.val);
                ll = ll.next;
                max = max.next;
            }

            ll.next = new ListNode(min.val);
            ll = ll.next;
            min = min.next;
        }

        while (max != null)
        {
            ll.next = new ListNode(max.val);
            ll = ll.next;
            max = max.next;
        }

        return result;
    }

    public ListNode MergeTwoLists(ListNode l1, ListNode l2)
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