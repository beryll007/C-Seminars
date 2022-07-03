// Задача№1. Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] CreateRandomBiDimArray(int m, int n, int max, int min) 
{
    double[,] newMatrix = new double[m, n];
    for (int i = 0; i < newMatrix.GetLength(0); i++)
    {
        for (int j = 0; j < newMatrix.GetLength(1); j++)
        {
            newMatrix[i, j] = Math.Round((new Random().NextDouble() * new Random().Next(min, max + 1)), 1);
            Console.Write(newMatrix[i, j] + "|");
        }
        Console.WriteLine();
        Console.WriteLine();
    }

    return newMatrix;
}
/*
Console.WriteLine("This program is designed to create bidimensional array filled with random real numbers\nReal numbers can be thought of as points on an infinitely long number line.");
Console.WriteLine("If that is clear, let's set parameters for the new array.\nLines: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Columns: ");
int n = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Max element: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Min element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Here is your array: ");
 Console.WriteLine();
double[,] array = CreateRandomBiDimArray(m, n, max, min);

*/
//Задача№2. Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1 7 -> такого числа в массиве нет

int[,] CreateRandomeTwoDemArray(int a, int b, int min, int max)
{
    int[,] newMatrix = new int[a, b];

    for (int i = 0; i < a; i++)
    {
        for (int j = 0; j < b; j++)
        {
            newMatrix[i, j] = new Random().Next(min, max + 1);
            Console.Write(newMatrix[i, j] + " ");
        }
        Console.WriteLine();
    }

    return newMatrix;
}

void FindElementInBiDimArray(int[,] array, int line, int column)
{
    if (line > array.GetLength(0) || column > array.GetLength(1) || line < 1 || column < 1)
        Console.WriteLine("there is no such element in array");

    else Console.WriteLine($"the element lying on {line} row and {column} column is {array[line - 1, column - 1]}");
}

Console.WriteLine("This algorythm is to create random bidimensional array of integer numbers\nand then to show the element of array lying on specified position");
Console.WriteLine();

Console.WriteLine("Let's set parameters for the new array.\nLines: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Columns: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Min element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Max element: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Here is the new array: ");
int[,] myArray = CreateRandomeTwoDemArray(a, b, min, max);

Console.WriteLine("Let's find the element in our array luying on the next position\nLine: ");
int line = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Column: ");
int column = Convert.ToInt32(Console.ReadLine());

FindElementInBiDimArray(myArray, line, column);



//Задача №3. Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
/*
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.*/

void FindAveregeInColumns(int[,] array)
{
    //double average = 0;

    for (int j = 0; j < array.GetLength(1); j++)
    {
        double sum = 0; 
        
        for (int i = 0; i < array.GetLength(0); i++)
        {
            sum += array[i, j];
        }
    
        Console.Write(Math.Round(sum / array.GetLength(0),2) + " | ");
    }
}

/*
Console.WriteLine("This algorythm is to create random bidimensional array of integer numbers\nand then to show the average of the elements in each column");
Console.WriteLine();

Console.WriteLine("Let's set parameters for the new array.\nLines: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Columns: ");
int b = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Min element: ");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Max element: ");
int max = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Here is your new array: ");
int[,] myArray = CreateRandomeTwoDemArray(a, b, min, max);

//int[,] myArray = CreateRandomeTwoDemArray(2, 4, 0, 3);
Console.WriteLine();
Console.WriteLine("Here is the average of the elements of each column: ");
FindAveregeInColumns(myArray);
*/






