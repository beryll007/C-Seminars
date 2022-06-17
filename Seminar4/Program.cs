// Программа нахождения суммы цифр, введенного числа
/*
int FindSumOfDigits(int num)
{
    int sum = 0;

    while (num > 0)
    {
        sum = sum + num % 10; // sum += num % 10;
        num = num / 10; // num /= 10; 
    }

    return sum;
}

Console.WriteLine("Input any number");

int num = Convert.ToInt32(Console.ReadLine());

int result = FindSumOfDigits(num);

Console.WriteLine($"Sum of digits in number {num} is {result}");
*/

// Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.
/*
int Summa (int a)
{
    int result = 0;
    int count = 1;
    while ( count <= a)
    {
        result = result + count;
        count ++;
    }
    return result;
}
Console.WriteLine("Enter your number ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Sum is: " + Summa(num));
*/

// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.
/*
int Fact (int a)
{
    int result = 1;
    int count = 1;
    while ( count <= a)
    {
        result = result * count;
        count ++;
    }
    return result;
}
Console.WriteLine("Enter your number ");
int num = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Product is: " + Fact(num));
*/

// Напишите программу, которая принимает на вход число и выдаёт кол-во цифр в числе.
/*
void Countofdigits(int a)
{
    int counter = 0;
    while (a > 0)
    {
        a = a / 10;
        counter++;
    }
    Console.WriteLine("Count of digits in your number is: " + counter);
}
Console.WriteLine("Input any number: ");
int a = Convert.ToInt32(Console.ReadLine());
Countofdigits(a);
*/

// Написать программу, которая выводит массив из 8 элементов, заполненный случайным образом 0 и 1.

int size = 8;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, 2);
}

for (int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
}