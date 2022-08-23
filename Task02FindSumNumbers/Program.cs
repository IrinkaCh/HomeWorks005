// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] FillArray()
{
    int[] array = new int[4];
    for (int i = 0; i < 4; i++)
    {
        array[i] = new Random().Next(-100,100);
    }
    return array;
}

void PrintArray(int[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
}

int[] arrayRes = FillArray();
PrintArray(arrayRes);


int FindSumNumbers(int[] arr)
{
    int sum = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 1)
        {
            sum = sum + arr[i];
        }
    }
    return sum;
}

int sum = FindSumNumbers(arrayRes);
System.Console.WriteLine();
System.Console.WriteLine(sum);
