using Sort.Classes;

List<int> list = new List<int> { 8, 6, 3, 9, 0, 1, 7, 2, 4, 5 };

//var sortedList = SelectionSortClass.SelectionSort(list);

//SelectionSort
//Console.WriteLine("Lista ordenada: " + string.Join(", ", sortedList));


var bubbleSortedList = BubbleSortClass.BubbleSort(list);

//BubbleSort
Console.WriteLine("Lista ordenada: " + string.Join(", ", bubbleSortedList));