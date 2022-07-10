//Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
//M = 1; N = 15 -> 120
//M = 4; N = 8. -> 30

int FindSumFromMToN(int n, int m)
{
    int sum = n;
    if (n != m)
        sum = n + FindSumFromMToN(n + 1, m);

    return sum;
}
/*
Console.WriteLine("Input lesser number ");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Input bigger number ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"The sum of natural elements from {n} to {m} is {FindSumFromMToN(n, m)}");
*/


//Задача 67: Напишите программу, которая будет принимать на вход число и возвращать кол-во его цифр.
//453 -> 3
//45 -> 2

int ShowAmountOfNumbers(int n)
{
    int count = 1;
    if (n / 10 == 0) return count;
        count = count + ShowAmountOfNumbers(n / 10);
    
    return count;
}

Console.WriteLine("Input any number to know how many digits it contains");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Your number {n} consists of {ShowAmountOfNumbers(n)} digits.");
