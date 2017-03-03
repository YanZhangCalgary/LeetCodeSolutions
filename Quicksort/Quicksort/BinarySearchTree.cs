using System;

namespace SortedDataToBST
{
    public class BinarySearchTree
    {

    }

    public class TreeNode
    {
        public int Value { get; set; }
        public TreeNode LeftNode { get; set; }
        public TreeNode RightNode { get; set; }

        public TreeNode(int val)
        {
            Value = val;
            LeftNode = null;
            RightNode = null;
        }
    }
}