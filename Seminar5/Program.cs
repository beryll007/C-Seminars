// Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. Найдите сумму отрицательных и положительных элементов массива. 

int[] CreateRandomArray(int size, int min, int max)// метод, генерирующий случайный массив

{
    int[] newArray = new int[size];

    for (int i = 0; i < size; i++)
    {
        newArray[i] = new Random().Next(min, max + 1);
        Console.Write(newArray[i] + " ");
    }
    Console.WriteLine();

    return newArray;
}

int FindPositiveSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] > 0) sum += array[i];
    }

    return sum;
}

int FindNegativeSum(int[] array)
{
    int sum = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] < 0) sum += array[i]; // sum = sum + array[i];
    }

    return sum;
}

/*
Console.WriteLine("What is the size of your array?");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the minimum element of your array?");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the maximum element of your array?");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

Console.WriteLine("Sum of positive numbers is " + FindPositiveSum(myArray));
Console.WriteLine("Sum of negative numbers is " + FindNegativeSum(myArray));
*/
// Напишите программу замены  элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.

int[] InverseArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        array[i] *= -1;
        Console.Write(array[i] + " ");
    }
    Console.WriteLine();

    return array;
}

/*
Console.WriteLine("What is the size of your array?");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the minimum element of your array?");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the maximum element of your array?");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

Console.WriteLine("");

Console.WriteLine("I've changed all the elements in array to the opposite ones ");

Console.WriteLine("");

int[] invArray = InverseArray(myArray);
*/

// Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
/*
string PresenceInArray (int num, int[] array)
{
    string result = null;
    
    for (int i = 0; i < array.Length; i++ )
    {
        if (array[i] == num) result = "Yes";
        
        else result = "No";
    }
    return result;
}

Console.WriteLine("What is the size of your array?");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the minimum element of your array?");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the maximum element of your array?");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

Console.WriteLine("Input any number you want to check if it is presented in your array: ");
int myNum = Convert.ToInt32(Console.ReadLine());

string NewResult = PresenceInArray (myNum, myArray); 

Console.WriteLine(NewResult);
*/


bool PresenceInArrayBool(int num, int[] array)     // Разобрать метод bool
{
    bool bb = false;

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            return true;
        }
    }
    return false;
}

string PresenceInArrayString(int num, int[] array)     // Не работает!!!
{
    string result = "error";

    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] == num)
        {
            result = "Yes";
        }
        if (array[i] != num) result = "No";
    }
    return result;
}

/*
Console.WriteLine("What is the size of your array?");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the minimum element of your array?");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the maximum element of your array?");
int max = Convert.ToInt32(Console.ReadLine());

int[] myArray = CreateRandomArray(size, min, max);

Console.WriteLine("Input any number you want to check if it is presented in your array: ");
int myNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(PresenceInArrayBool(myNum, myArray));
*/

//Задайте одномерный массив из 12 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].

int AmountElementsInRange(int[] array, int min, int max)
{
    int counter = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i] >= min && array[i]<=max) counter++;
    }
    return counter;
}

Console.WriteLine("What is the size of your array?");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the minimum element of your array?");
int min = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("What is the maximum element of your array?");
int max = Convert.ToInt32(Console.ReadLine());

int [] myArray = CreateRandomArray(size, min, max); 

Console.WriteLine("Input the lower range: ");
int minNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the higher range: ");
int maxNum = Convert.ToInt32(Console.ReadLine());

Console.WriteLine($"In the range from {minNum} to {maxNum} there are {AmountElementsInRange(myArray, minNum, maxNum)} element(s) in created array ");
