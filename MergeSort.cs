using System;

class Program
{
    static void Main(string[] args)
    {
        int[] array = { 5, 3, 8, 4, 2 };
        BubbleSort(array);
        Console.WriteLine(string.Join(", ", array));
    }

    static void BubbleSort(int[] arr)
    {
        int n = arr.Length;
        for (int i = 0; i < n - 1; i++)
        {
            for (int j = 0; j < n - i - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    // ����� ����������
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }
        }
    }
}