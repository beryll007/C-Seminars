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

//int[,] array = CreateRandomeTwoDemArray(4,5,1,9);

//Задача№1
//Задайте двумерный массив размера m на n, каждый элемент в массиве находится по формуле: Aij = i+j. Выведите полученный массив на экран.

int[,] CreateTwoDemArray(int m, int n)
{
    int[,] newMatrix = new int[m, n];

    for (int i = 0; i < m; i++)
        for (int j = 0; j < n; j++)
            newMatrix[i, j] = i + j;

    return newMatrix;
}

void ShowTwoDimArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j =0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i,j] + " ");
        }
        Console.WriteLine();
    }
}

//int [,] array = CreateTwoDemArray(5,6);
//ShowTwoDimArray(array);

//Задача№2
//Задайте двумерный массив. Найдите элементы, у которых оба индекса чётные, и замените эти элементы на их квадраты.

int[,] UpdateArrayEvenIndexToQuad(int[,]array)
{
    for (int i = 0; i < array.GetLength(0); i+=2)
        for (int j = 0; j < array.GetLength(1); j+=2)
                array[i,j] *= array[i,j];

    return array;
}

/*
int[,] myArray = CreateRandomeTwoDemArray(5,5,2,4);
Console.WriteLine();
UpdateArrayEvenIndexToQuad(myArray);
ShowTwoDimArray(myArray);
*/

//Задача№3
//Задайте двумерный массив. Найдите сумму элементов, находящихся на главной диагонали (с индексами (0,0); (1;1) и т.д.

int SumOfMainDiagonal(int[,]array)
{ 
    int sum = 0;
    for (int i = 0; i < array.GetLength(1); i++)
        sum += array[i,i];
         
    return sum;
}


int[,] myArray = CreateRandomeTwoDemArray(5,5,2,4);

Console.WriteLine($"Sum of elements lying on the main diagonal is {SumOfMainDiagonal(myArray)}");