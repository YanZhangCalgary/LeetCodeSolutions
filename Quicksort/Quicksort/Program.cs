using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SortedDataToBST;

namespace Quicksort
{
    class Program
    {
        static void Main(string[] args)
        {

            int[] dataToBeSorted = new int[] {9,40, 54, 63, 21, 33, 14, 18, 90}; //{54, 26, 93, 17, 77, 31, 44, 55, 20};
            //QuickSort(dataToBeSorted);
            int[] sortedData =new int[] { 9,10,14,15,16};//,15,16,18,20,25,26,28,30,31,32,35,36};
            //var myQuickSort = new QuickSort2();
            //myQuickSort.QuickSortMethod(dataToBeSorted);
            string[] words = new string[] { "Alaska", "Peace"};
            //var linkedList = new SortedSingleList();
            //var node = linkedList.ConstructListFromSortedArray(sortedData);
            //var treeNode = linkedList.CreateBalancedBST(node);
            //linkedList.InOrderTraverse(treeNode);
            //var keyboardRow = new KeyboardRow();
            //var returns = keyboardRow.FindWords(words);

            //var asyncTester = new AsyncTest();
            //Task<AsyncTest>.Factory.StartNew(asyncTester.MyMethodAsync()); 
            //var digits = new AddDigitsSolution();
            //digits.AddDigits(10);

            Console.Read();
        }

        static void QuickSort(int[] data)
        {
            QuickSortHelper(0, data.Length - 1, data);
        }

        static void QuickSortHelper(int first, int last, int[] data)
        {
            if (first < last)
            {
                var pivotPosition = Partition(first, last, data);

                QuickSortHelper(first, pivotPosition - 1, data);
                
                QuickSortHelper( pivotPosition + 1,last, data);
            }
        }

        static int Partition(int first, int last, int[] data)
        {
           var leftIndex = first+1;
           

            var rightIndex = last;
            var pivot = data[first];
            
            bool done = false;
            while (!done)
            {
                while (leftIndex <= rightIndex && data[leftIndex] <= pivot)
                {
                    leftIndex++;
                }
                while (leftIndex <= rightIndex && data[rightIndex] >= pivot)
                {
                    rightIndex--;
                }

                if (rightIndex < leftIndex)
                {
                    done = true;
                }
                else
                {
                    Swap(ref data[leftIndex], ref data[rightIndex]);
                    PrintData(data);
                    Console.WriteLine("The returned right position is " + rightIndex);
                    Console.WriteLine("The returned left position is " + leftIndex);
                }
            }
            Swap(ref data[first], ref data[rightIndex]);
            PrintData(data);
            Console.WriteLine("The returned right position is " + rightIndex);
            Console.WriteLine("The returned left position is " + leftIndex);
            return rightIndex;
        }

        static void Swap(ref int dataA, ref int dataB)
        {
            var temp = dataA;
            dataA = dataB;
            dataB = temp;
        }

        static void PrintData(int[] data)
        {
            for (int i = 0; i < data.Length - 1; i++)
            {
                Console.Write(data[i]+" ");
            }
            Console.WriteLine(" ");
        }

      
    }
}
