//Задача №1 Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B.

//3, 5 -> 243 (3⁵)
//2, 4 -> 16
/*
Console.WriteLine("This programm is to calcualte the number raised in the natural power.");
Console.WriteLine("Input any number: ");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input the power you want your number to be raised in: ");
int b = Convert.ToInt32(Console.ReadLine());
if (b < 0) 
{
    Console.WriteLine("the power you've entered is not a natural number. Input non-negative integer.");    
}
else 
{
    int result = 1;

    for (int i = 0; i < b; i++ ) 
    {
        result *= a; 
    }

Console.WriteLine($"number {a} in a power of {b} is {result}");
}
*/

//Задача №2 Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.

//1, 2, 5, 7, 19, 3, 44, 3 -> [1, 2, 5, 7, 19, 3, 44, 3]

int size = 8;
int[] array = new int[size];

for (int i = 0; i < size; i++)
{
    array[i] = new Random().Next(0, 100);
}

for (int i = 0; i < size; i++)
{
    Console.Write(array[i] + " ");
}
