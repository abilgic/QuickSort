
using System;

int[] data = { 8, 7, 2, 1, 0, 9, 6 };
Console.WriteLine("Unsorted Array");
foreach (var item in data)
{
    Console.Write($"{item} ");
}
Console.WriteLine();
QuickSort(data, 0, data.Count() - 1);

Console.WriteLine("Sorted Array in Ascending Order: ");
foreach (var item in data)
{
    Console.Write($"{item} ");
}


int Partition(int[] data, int low, int high)
{
    int pivot = data[high];
    int i = low - 1;


    for (int j = low; j <= high - 1; j++)
    {
        if (data[j] < pivot)
        {
            i++;
            swap(data, i, j);
        }
    }

    swap(data, i + 1, high);
    return i + 1;

}

void swap(int[] arr, int i, int j)
{
    int temp = arr[i];
    arr[i] = arr[j];
    arr[j] = temp;
}

void QuickSort(int[] data, int low, int high)
{
    if (low < high)
    {
        int pivot = Partition(data, low, high);

        QuickSort(data, low, pivot - 1);
        QuickSort(data, pivot + 1, high);
    }
}



