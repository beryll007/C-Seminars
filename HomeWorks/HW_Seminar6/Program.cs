//Задача №1.Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int PositiveNumbersAmount(int[] array)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) counter++;
    }
    return counter;
}

int[] CreateArray(int m)
{
    int[] numbers = new int[m];

    for (int i = 0; i < m; i++)
    {
        Console.WriteLine($"Input {i + 1} number: ");
        numbers[i] = Convert.ToInt32(Console.ReadLine());
    }

    return numbers;
}
/*
Console.WriteLine("How many numbers do you want to input?");

int m = Convert.ToInt32(Console.ReadLine());

int[] userNumbers = CreateArray(m);

Console.WriteLine("Here are your numbers: ");
for (m = 0; m < userNumbers.Length; m++)
{
    Console.Write(userNumbers[m] + " ");
}
Console.WriteLine("");

int amount = PositiveNumbersAmount(userNumbers);

if (amount > 1) Console.WriteLine($"and there are {amount} numbers greater than 0 among them");
if (amount == 1) Console.WriteLine($"and there is {amount} number greater than 0 among them");
if (amount == 0) Console.WriteLine($"and there is no numbers greater than 0 among them");
*/

//Задача №2 Напишите программу, которая будет создавать копию заданного массива с помощью поэлементного копирования.

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

int [] arrayCopy (int[] array)
{
    int[] arrayCopy = new int[array.Length];
    for (int i = 0; i < array.Length; i++)
    {
        arrayCopy[i] = array[i];
        Console.Write(arrayCopy[i] + " ");
    }
    
    Console.WriteLine("~Array copied");
    
    return arrayCopy;
}

//int[] myArray = new int [5] {12, 658, 35, 51, -54};

Console.WriteLine("Input array parameters you want me to create \nSize: ");
int size = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Lower bound: ");
int min = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Upper bound: ");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max);

int [] myArrayCopy = arrayCopy(myArray);
