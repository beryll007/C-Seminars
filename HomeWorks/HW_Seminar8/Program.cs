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

//Задача№1: Задайте двумерный массив. Напишите программу, которая упорядочит по возрастанию элементы каждой строки двумерного массива.
//Например, задан массив:
/*1 4 7 2
5 9 2 3
8 4 2 4
В итоге получается вот такой массив:
1 2 4 7
2 3 5 9
2 4 4 8*/

int[,] ElementsInOrder(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            for (int x = 0; x < array.GetLength(1); x++)
                if (array[i, j] < array[i, x])
                {
                    int temp = array[i, j];
                    array[i, j] = array[i, x];
                    array[i, x] = temp;
                }
        }
    }
    return array;
}

Console.WriteLine("This algorythm is to create random bidimensional array and then put in order elements of the array in each row.");
Console.WriteLine("Let's set parameters for the matrix:\nRows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Min value of an element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Max value of an elemnt: ");
int max = Convert.ToInt32(Console.ReadLine());
int [,] myArray = CreateBiDimArray(m,n,min,max);
Console.WriteLine("Here is your array: \n");
ShowArray(myArray);
Console.WriteLine();
Console.WriteLine("Now all the elements of each row are in order from lesser to greater  :\n");
ElementsInOrder(myArray);
ShowArray(myArray);


/*Задача №2: Задайте прямоугольный двумерный массив. Напишите программу, которая будет находить строку с наименьшей суммой элементов.
Например, задан массив:
1 4 7 2
5 9 2 3
8 4 2 4
5 2 6 7
Программа считает сумму элементов в каждой строке и выдаёт номер строки с наименьшей суммой элементов: 1 строка
*/

int FindSumInRow(int[,] array)
{
    int SumInRow = 0;
    int sum;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum += array[i, j];
        }
        SumInRow = sum;
        Console.Write(SumInRow + " ");
    }
    return SumInRow;
}

void FindRowWithLesserSum(int[,] array)
{
    int minRow = 0;
    int rowWithMinSum = 0;

    for (int j = 0; j < array.GetLength(1); j++)
        minRow += array[0, j];
    //Console.Write("Sum in the 1st row is " + minRow);
    

    for (int i = 1; i < array.GetLength(0); i++)
    {
        int SumInRow = 0;
        for (int j = 0; j < array.GetLength(1); j++)
            SumInRow += array[i, j];
        //Console.WriteLine($"Sum in {i+1} row is {SumInRow}");
    
        if (SumInRow < minRow)
        {
            rowWithMinSum = i;
            minRow = SumInRow;
        }
    }
    Console.WriteLine();
    Console.WriteLine($"The row {rowWithMinSum + 1} is the row with the lesser sum of its elements.");
}
/*
Console.WriteLine("This algorythm is to create random bidimensional array with your parametres and show you the row with the lesser sum of its elements.");
Console.WriteLine("Let's set parameters for the matrix:\nRows: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Columns: ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Min value of an element: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Max value of an elemnt: ");
int max = Convert.ToInt32(Console.ReadLine());
int[,] myArray = CreateBiDimArray(m, n, min, max);

Console.WriteLine("Here is your array: \n");
ShowArray(myArray);
Console.WriteLine();

FindRowWithLesserSum(myArray);
*/

//Задача №3. Заполните спирально массив 4 на 4.
/*
Например, на выходе получается вот такой массив
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/


int[,] SpiralArray(int size, int firstElement)
{
    int[,] array = new int[size, size];

    for (int j = 0; j < size; j++)
    {
        array[0, j] = firstElement;
        firstElement++;
    }
    for (int i = 1; i < size; i++)
    {
        array[i, size - 1] = firstElement;
        firstElement++;
    }
    for (int j = size - 2; j >= 0; j--)
    {
        array[size - 1, j] = firstElement;
        firstElement++;
    }
    for (int i = size - 2; i > 0; i--)
    {
        array[i, 0] = firstElement;
        firstElement++;
    }
    //_________________________________________________perimeter
    int x = 1;
    int y = 1;

    while (firstElement < size * size)
    {
        while (array[x, y + 1] == 0)
        {
            array[x, y] = firstElement;
            firstElement++;
            y++;
        }
        while (array[x + 1, y] == 0)
        {
            array[x, y] = firstElement;
            firstElement++;
            x++;
        }
        while (array[x, y - 1] == 0)
        {
            array[x, y] = firstElement;
            firstElement++;
            y--;
        }
        while (array[x - 1, y] == 0)
        {
            array[x, y] = firstElement;
            firstElement++;
            x--;
        }
    }

    for (int i = 0; i < size; i++)
    {
        for (int j = 0; j < size; j++)
        {
            if (array[i, j] == 0)
            {
                array[i, j] = firstElement;
            }
        }
    }
    return array;
}

//ShowArray(SpiralArray(4, 1));



