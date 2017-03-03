using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace SortedDataToBST
{
    public class SortedSingleList
    {

        public ListNode ConstructListFromSortedArray(int[] data)
        {
            ListNode header = null;
            ListNode pointer = null;

            if (data == null || data.Length == 0) return null;
            header = new ListNode(data[0]);
            pointer = header;
            for (int i = 1; i < data.Length; i++)
            {
                pointer.Next = new ListNode(data[i]);
                pointer = pointer.Next;
            }
            return header;

        }

        public TreeNode CreateBalancedBST(ListNode header)
        {
            if (header == null) return null;
            var size = GetSize(header);
            var pointer = header;
            return BalancedBSTHelper(ref pointer, 0, size - 1);
        }

        public int GetSize(ListNode header)
        {
            ListNode curr = header;
            int size = 0;
            while (curr != null)
            {
                curr = curr.Next;
                size++;
            }
            return size;
        }

        public TreeNode BalancedBSTHelper(ref ListNode head, int low, int high)
        {
            if (low > high) return null;
         
            int mid =  (high-low) / 2 + low;
            TreeNode left = BalancedBSTHelper(ref head, 0, mid - 1);
            TreeNode root = new TreeNode(0);
            root.Value = head.Value;
            head = head.Next;
            TreeNode right = BalancedBSTHelper(ref head, mid + 1, high);
            root.LeftNode = left;
            root.RightNode = right;
            return  root;
        }

        public void InOrderTraverse(TreeNode root)
        {
            if (root == null) return;
            InOrderTraverse(root.LeftNode);
            Console.WriteLine(root.Value);
            InOrderTraverse(root.RightNode);
        }
    }

    public class ListNode
    {
        public int Value { get; set; }
        public ListNode Next { get; set; }

        public ListNode(int val)
        {
            Value = val;
            Next = null;
        }

    }
}
