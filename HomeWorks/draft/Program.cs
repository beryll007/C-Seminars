
//Задача №3. Заполните спирально массив 4 на 4.
/*
Например, на выходе получается вот такой массив
1 2 3 4
12 13 14 5
11 16 15 6
10 9 8 7*/

void ShowArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
            if (array[i, j] < 10)
            {
                Console.Write(array[i, j] + "  ");
            }
            else
            {
                Console.Write(array[i, j] + " ");
            }
        
        Console.WriteLine();
    }
}

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

int Factorial (int n)
{
    if (n==1) return 1;
    return n*Factorial (n-1);
      
}

Console.WriteLine(Factorial(4));


