
using System.Security.Cryptography;

namespace Sort.Classes
{
    public class Merge
    {
        public Merge()
        {
            
        }

        public static List<int> MergeSort(List<int> list)
        {
            if (list.Count <= 1)
                return list;

            int mid = list.Count / 2;
            List<int> left = new List<int>(list.GetRange(0, mid));
            List<int> right = new List<int>(list.GetRange(mid, list.Count - mid));

            MergeSort(left);
            MergeSort(right);

            MergeList(left, right, list);

            return list;    
        }

        private static List<int> MergeList(List<int> left, List<int> right, List<int> list)
        {
            int leftIndex = 0, rightIndex = 0, k = 0;

            while (leftIndex < left.Count && rightIndex < right.Count)
            {
                if (left[leftIndex] <= right[rightIndex])
                    list[k++] = left[leftIndex++];
                else
                    list[k++] = right[rightIndex++];
            }

            while (leftIndex < left.Count)
                list[k++] = left[leftIndex++];

            while (rightIndex < right.Count)
                list[k++] = right[rightIndex++];

            return list;
        }
    }
}
