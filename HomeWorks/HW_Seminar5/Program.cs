// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int[] CreateRandomArray(int size, int min, int max)
{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int CountOfEvenElements(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] % 2 == 0) counter++;
    }
    return counter;
}
/*
int min = 100;
int max = 1000;

Console.WriteLine("This algorythm is desigend to create random array of three-figures positive numbers and calculate sum of even numbers in array");
Console.WriteLine("How many elements do you want your array to have?");
int size = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

Console.WriteLine($"There are {CountOfEvenElements(myArray)} even elements in created array");
*/
//Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int SumOfOddPosition(int[] array)
{
    int sum = 0;
    for (int i = 1; i < array.Length; i += 2)
    {
        sum = sum + array[i];
    }
    return sum;
}

/*
Console.WriteLine("Input array parameters you want me to create \nSize: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lower bound: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Upper bound: ");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);
Console.WriteLine("Sum of elements holding odd position in created array is " + SumOfOddPosition(myArray));
*/

//Задача 38: Задайте массив вещественных(дробных, см. Random().NextDouble()) чисел. Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] CreateRandomDouble(int size)
{
    double[] newArray = new double[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = Math.Round(new Random().NextDouble(), 5);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

double FindDiffMaxAndMin(double[] array)
{
    double max = array[0];
    double min = array[0];
    double diff = 0;

    for (int i = 1; i < array.Length; i++)
    {
        if (array[i] > max) max = array[i];
        if (array[i] < min) min = array[i];
    }
    Console.WriteLine($"Min element of your array is: {min}");
    Console.WriteLine($"Max element of your array is: {max}");

    diff = max - min;
    return diff;
}
/*
Console.WriteLine("Input the size of array you want me to create: ");

int size = Convert.ToInt32(Console.ReadLine());

double[] myArray = CreateRandomDouble(size);

double result = FindDiffMaxAndMin(myArray);

Console.WriteLine($"The difference between max and min elements in created array is: {result}");
*/










