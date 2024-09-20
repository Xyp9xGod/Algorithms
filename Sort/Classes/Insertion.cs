namespace Sort.Classes
{
    public class Insertion
    {
        public Insertion()
        {
            
        }

        public static List<int> InsertionSort(List<int> list)
        {
            var length = list.Count;

            for(int currentIndex = 1; currentIndex < length; currentIndex++)
            {
                var count = currentIndex;

                while (count > 0)
                {
                    var previousIndex = count - 1;

                    if (list[count] < list[previousIndex])
                    {
                        var aux = list[count];
                        list[count] = list[previousIndex];
                        list[previousIndex] = aux;
                    }

                    count--;
                }
            }

            return list;
        }
    }
}
