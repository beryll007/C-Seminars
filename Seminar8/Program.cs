// Задача№1. Задайте двумерный массив. Напишите программу, которая поменяет местами первую и последнюю строку массива

int[,] CreateBiDimArray(int m, int n, int min, int max)
{
    int[,] array = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            array[i, j] = new Random().Next(min, max);
    return array;
}

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            Console.Write(array[i, j] + " ");

        Console.WriteLine();
    }
}

int[,] ChangeLines(int[,] array, int strIndex1, int strIndex2)
{
    int temp;
    for (int j = 0; j < array.GetLength(1); j++)
    {
        temp = array[strIndex1, j];
        array[strIndex1, j] = array[strIndex2, j];
        array[strIndex2, j] = temp;
    }

    return array;
}
/*
int[,] myArray = CreateBiDimArray(4,5,1,9);
ShowArray(myArray);
myArray = ChangeLines(myArray, 0 , myArray.GetLength(0) - 1);
Console.WriteLine();
ShowArray(myArray);
*/
//Задача№2 Задайте двумерный массив. Напишите программу, которая заменяет строки на столбцы. 
//В случае, если это невозможно, программа должна вывести сообщение для пользователя.

int[,] ChangeLineToColumns(int[,] array)
{

    for (int i = 0; i < array.GetLength(0) - 1; i++)
    {
        for (int j = i + 1; j < array.GetLength(1); j++)
        {
            int temp = array[i, j];
            array[i, j] = array[j, i];
            array[j, i] = temp;
        }
    }
    return array;
}
/*
Console.WriteLine("This algorythm is to transpose matrix.\nTranspose of a matrix is flipping a matrix over its diagonal.");

Console.WriteLine("Let's set parameters for the matrix:\nRows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Min value of an element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Max value of an elemnt: ");
int max = Convert.ToInt32(Console.ReadLine());
int [,] myArray = CreateBiDimArray(m,n,min,max);
Console.WriteLine("Here is your array: ");
ShowArray(myArray);
Console.WriteLine();

if (m == n) 
{
    myArray = ChangeLineToColumns(myArray);
    Console.WriteLine("And transposed one: ");
    ShowArray(myArray);
}
else Console.WriteLine ("But it is unable to transpose matrix which is not square");
*/

//Задача№3 Из двумерного массива целых чисел удалить строку и столбец, на пересечении которых расположен наименьший элемент.

int FindMinElementInMatrix(int[,] array)
{
    int min = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min) min = array[i, j];

        }
    }
    Console.WriteLine($"The minimal element is {min}");
    return min;
}

int[,] DeleteRowColumnWithMinElement(int[,] array)
{
    int minRow = 0;
    int minColumn = 0;
    int min = array[minRow, minColumn];

    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            if (array[i, j] < min)
            {
                min = array[i, j];
                minRow = i;
                minColumn = j;
            }
        }
    }

    for (int i = 0; i < array.GetLength(0); i++)
      array [i,minColumn] = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            array[minRow,j] = 0;

return array;
}

Console.WriteLine("Let's set parameters for the matrix:\nRows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Min value of an element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Max value of an elemnt: ");
int max = Convert.ToInt32(Console.ReadLine());
int [,] myArray = CreateBiDimArray(m,n,min,max);
Console.WriteLine("Here is your array: ");
ShowArray(myArray);
Console.WriteLine();

ShowArray(DeleteRowColumnWithMinElement(myArray));