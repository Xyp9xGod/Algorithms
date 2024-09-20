using Sort.Classes;
using Sort.Extensions;

List<int> list = new List<int> { 8, 6, 3, 9, 0, 1, 7, 2, 4, 5 };

// Solicita ao usuário que escolha o algoritmo de ordenação
Console.WriteLine("Choose the Sort Algorithm:");
Console.WriteLine("1 - Bubble Sort");
Console.WriteLine("2 - Selection Sort");
Console.WriteLine("3 - Insertion Sort");
Console.WriteLine("==========================");

string algoritm = Console.ReadLine();

if (!Util.IsValidOption(algoritm))
{
    Console.WriteLine("Invalid Option. The program will close.");
    return; // Encerra o programa se a opção for inválida
}

Console.WriteLine("Would you inform some values? (Y/N)");
string chooseToInformList = Console.ReadLine().ToUpper();

List<int> values;

if (chooseToInformList == "Y")
{
    Console.WriteLine("Inform the values separated by commas (ex: 5,3,8,1):");
    string inputValues = Console.ReadLine();
    values = inputValues.Split(',').Select(int.Parse).ToList();
}
else
{
    values = new List<int> { 8, 6, 3, 9, 0, 1, 7, 2, 4, 5 };
    Console.WriteLine("No list provided. Using a default list: 8, 6, 3, 9, 0, 1, 7, 2, 4, 5");
}

switch (algoritm)
{
    case "1":
        Bubble.BubbleSort(values);
        Console.WriteLine("Result List using Bubble Sort: ");
        break;
    case "2":
        Selection.SelectionSort(values);
        Console.WriteLine("Result List using Selection Sort: ");
        break;
    case "3":
        Insertion.InsertionSort(values);
        break;
    default:
        Console.WriteLine("Opção inválida, saindo...");
        return;
}

Console.WriteLine(string.Join(", ", values));