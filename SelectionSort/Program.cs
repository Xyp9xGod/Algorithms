List<int> list = new List<int> { 8, 6, 3, 9, 0, 1, 7, 2, 4, 5 };

SelectionSort(list);

// Imprimir a lista ordenada
Console.WriteLine("Lista ordenada: " + string.Join(", ", list));

static List<int> SelectionSort(List<int> list)
{
    var minIndex = 0;

    for (int currentIndex = 0; currentIndex <= list.Count - 1; currentIndex++)
    {
        minIndex = currentIndex;

        for (int searchIndex = currentIndex; searchIndex < list.Count; searchIndex++)
        {
            if (list[searchIndex] < list[minIndex])
            {
                minIndex = searchIndex;
            }
        }

        if (list[currentIndex] > list[minIndex])
        {
            var aux = list[currentIndex];
            list[currentIndex] = list[minIndex];
            list[minIndex] = aux;
        }
    }

    return list;
}
