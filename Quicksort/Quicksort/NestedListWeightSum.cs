using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{

    /// <summary>
    /// Given a nested list of integers, return the sum of all integers in the list weighted by their depth.

    ///Each element is either an integer, or a list -- whose elements may also be integers or other lists.

    /// Example 1:
    ///Given the list[[1, 1],2,[1,1]], return 10. (four 1's at depth 2, one 2 at depth 1)

    ///Example 2:
    ///Given the list[1,[4,[6]]], return 27. (one 1 at depth 1, one 4 at depth 2, and one 6 at depth 3; 1 + 4*2 + 6*3 = 27)
    /*
     * // This is the interface that allows for creating nested lists.
     * // You should not implement it, or speculate about its implementation
     * public interface NestedInteger
        {
     *
     *     // @return true if this NestedInteger holds a single integer,
     *     // rather than a nested list.
     *     public boolean isInteger();
     *
     *     // @return the single integer that this NestedInteger holds,
     *     // if it holds a single integer
     *     // Return null if this NestedInteger holds a nested list
     *     public Integer getInteger();
     *
     *     // @return the nested list that this NestedInteger holds,
     *     // if it holds a nested list
     *     // Return null if this NestedInteger holds a single integer
     *     public List<NestedInteger> getList();
     * }
     */
    /// </summary>
    public class NestedListWeightSum
    {
        public int GetNodeWeightSum(int depth, List<NestedListNode> nodes)
        {
            if (nodes == null || nodes.Count == null ) return 0;
            var sum = 0;

            foreach (var node in nodes)
            {
                if (node.IsInteger)
                {
                    sum += depth*node.Data;
                }
                else
                {
                    sum += GetNodeWeightSum(depth + 1, node.ChildNodes);
                }
                
            }

            return sum;
        }

        public int GetListIntSum(int depth, List<int> data)
        {
            if (data == null || data.Count == 0) return 0;
            var sum = 0;
            foreach (var val in data)
            {
                sum += depth*val;
            }
            return sum;
        }

    }

    public class NestedListNode
    {
        public int Data { get; set; }

        public bool IsInteger => Data > 0 && ChildNodes == null;
        public List<NestedListNode> ChildNodes { get; set; }
    }
}
