// Задача 34. Задайте массив, заполненный случайными положительными трехзначными числами. 
// Напишите программу, которая покажет количество четных чисел в массиве.
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; 
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue+1); 
    
    return newArray;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindEvenCount(int[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) count ++;
    }
    return count;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, 100, 1000);
ShowArray(newArray);

Console.WriteLine($"Count of even numbers in massive is {FindEvenCount(newArray)}");
*/

//Задача 36. Задайте одномерный массив, заполненный случайными числами.
// Найдите сумму элементов, стоящих на нечетных позициях.
/*
int[] CreateRandomArray (int size, int minValue, int maxValue)
{
    int[] newArray = new int[size]; 

    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue+1); 
    
    return newArray;
}

void ShowArray (int[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");
    Console.WriteLine();
}

int FindSumNotEvenIndex(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (i % 2 != 0) sum += array[i];
    }
    return sum;
}

Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

Console.WriteLine($"Sum of not even index elements is {FindSumNotEvenIndex(newArray)}");
*/

// Задача 38. Задайте массив вещественных чисел.
// найдите разницу между максимальным и минимальным элементами массива.
/*
double[] CreateRandomArray (int size, int minValue, int maxValue)
{
    double[] newArray = new double[size]; 
    for (int i = 0; i < size; i++)
        newArray[i] = new Random().Next(minValue, maxValue+1) + new Random().NextDouble();
    return newArray;
}

void ShowArray (double[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write($"{array[i]:f2}  ");
    Console.WriteLine();
}

double FindDifference(double[] array)
{
    double difference = 0;
    int min = 0;
    int max = 0;
    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] < array[min]) min = i; 
        if (array[i] > array[max]) max = i;
    }
    difference = array[max] - array[min];
    return Math.Round(difference,2);
}
Console.Write("Input size of array: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.Write("Input min posible value: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.Write("Input max posible value: ");
int max = Convert.ToInt32(Console.ReadLine());

double[] newArray = CreateRandomArray(size, min, max);
ShowArray(newArray);

Console.WriteLine($"Difference between max and min elements of massive is {FindDifference(newArray)}");
*/