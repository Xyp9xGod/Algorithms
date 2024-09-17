
List<int> list = new List<int> { 8, 6, 3, 9, 0, 1, 7, 2, 4, 5 };

BubbleSort(list);

// Imprimir a lista ordenada
Console.WriteLine("Lista ordenada: " + string.Join(", ", list));

static List<int> BubbleSort(List<int> list)
{
    for(int i = 1; i <= list.Count; i++)
    {
        if(list[i] == list[i-1])
        {
            var aux = list[i];

        }
    }

    return list;
}