namespace Sort.Classes
{
    public class BubbleSortClass
    {
        public BubbleSortClass() { }

        public static List<int> BubbleSort(List<int> list)
        {
            var length = list.Count;

            for (int i = 0; i < length - 1; i++)
            {
                for (int j = 0; j < length - i - 1; j++)
                {
                    if (list[j] > list[j + 1])
                    {
                        var aux = list[j];
                        list[j] = list[j + 1];
                        list[j + 1] = aux;
                    }
                }
            }

            return list;
        }
    }
}
