using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Quicksort
{
   public class QuickSort2
    {
       public void QuickSortMethod(int[] data1)
       {
            Console.WriteLine("Initial data is:");
            PrintData(data1);
            QuickSortHelper(data1,0, data1.Length - 1);
       }
       private void QuickSortHelper(int[] data,int first, int last)
       {
           if (first > last) return;
           
               int partitionPos = Partition(data, first, last);

                QuickSortHelper(data,first, partitionPos - 1);
                QuickSortHelper(data, partitionPos + 1, last);
           
       }

       public int Partition(int[] data, int first, int last)
       {
           
            int pivot = data[last];
           int leftIndex = first;
           int rightIndex = last-1;
           var done = false;
           while (!done )
           {
               while (leftIndex <= rightIndex && data[leftIndex] <= pivot)
                   leftIndex++;
                while (leftIndex <= rightIndex && data[rightIndex] >= pivot)
                    rightIndex--;
               if (leftIndex > rightIndex)
               {
                   done = true;
               }
               else
               {
                   Swap(ref data[leftIndex], ref data[rightIndex]);
                   PrintData(data);
                }
            }
           
           Swap(ref data[leftIndex], ref data[last]);
           
           PrintData(data);
          Console.WriteLine("The first is " + first + "; The last is "+last);
           
            return leftIndex;
       }

       public void Swap(ref int a, ref int b)
       {
           if (a == b) return;
           var temp = a;
           a = b;
           b = temp;
       }

        static void PrintData(int[] data)
        {
            for (int i = 0; i <= data.Length - 1; i++)
            {
                Console.Write(data[i] + " ");
            }
            Console.WriteLine(" ");
        }
    }
}
