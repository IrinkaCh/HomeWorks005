// Задача 38: Задайте массив вещественных чисел. 
// Найдите разницу между максимальным и минимальным элементов массива.

// [3 7 22 2 78] -> 76

double[] FillArray()
{
    double[] array = new double[5];
    for (int i = 0; i < 5; i++)
    {
        array[i] = new Random().Next(1,100);
    }
    return array;
}

void PrintArray(double[] arr)
{
for (int i = 0; i < arr.Length; i++)
{
    Console.Write($"{arr[i]} ");
}
}
double[] arrayRes = FillArray();
PrintArray(arrayRes);


double FindMaxNumbers(double[] arr)
{
    double max = arr[0];
    
    for (int i = 0; i < arr.Length; i++)
    {
        if (max < arr[i])
        {
            max = arr[i];
            
        }
        
    }
    return max;
}

double max = FindMaxNumbers(arrayRes);
// System.Console.WriteLine();
// System.Console.WriteLine(max);

double FindMinNumbers(double[] arr)
{
    double min = arr[0];
    for (int i = 0; i < arr.Length; i++)
    {
        if (min > arr[i])
        {
            min = arr[i];
            
        }
        
    }
    return min;
}

double min = FindMinNumbers(arrayRes);
// System.Console.WriteLine();
// System.Console.WriteLine(min);

double diff = 0;
// double diff = max - min;

// System.Console.WriteLine();
// System.Console.WriteLine(diff);

Console.WriteLine(FindDiffNumber(diff));
double FindDiffNumber(double diff)
{
double result = max - min;
return result;
}
double result = FindDiffNumber(diff);
System.Console.WriteLine(result);