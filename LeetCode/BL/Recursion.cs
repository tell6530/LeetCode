using LeetCode.BE;

namespace LeetCode.BL
{
    public class Recursion
    {
        /// <summary>
        /// No.21 Merge Two Sorted Lists(Easy)
        /// </summary>
        /// <param name="l1">ListNode</param>
        /// <param name="l2">ListNode</param>
        /// <returns>
        /// ListNode
        /// </returns>
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null) return l2;
            if (l2 == null) return l1;

            var result = new ListNode(); 
            
            result.val = (l1.val <= l2.val) ? l1.val : l2.val;
            result.next = (l1.val <= l2.val) ? this.MergeTwoLists(l1.next, l2) : this.MergeTwoLists(l1, l2.next);

            return result;
        }
    }
}