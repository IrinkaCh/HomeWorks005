//  Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. 
// Напишите программу, которая покажет количество чётных чисел в массиве.
// [345, 897, 568, 234] -> 2

int[] FillArray()
{
    int[] array = new int[4];
    for (int i = 0; i < 4; i++)
    {
        array[i] = new Random().Next(100,1000);
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

int FindEvenCountNumbers(int[] arr)
{
    int count = 0;
    for (int i = 0; i < arr.Length; i++)
    {
        if (i % 2 == 0)
        {
            count++;
        }
    }
    return count;
}

int count = FindEvenCountNumbers(arrayRes);
System.Console.WriteLine();
System.Console.WriteLine(count);

