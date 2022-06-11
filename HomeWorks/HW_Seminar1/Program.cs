// Задача №1 Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.

/* 
int num1, num2;

Console.Write("Input first number: ");

num1 = Convert.ToInt32(Console.ReadLine()); 

Console.Write("Input second number: ");

num2 = Convert.ToInt32(Console.ReadLine());

if (num1 == num2)
{ 
    Console.WriteLine(num1 + " is equal to " + num2);
}
else
{ 
    
    if (num1 > num2)
        {
            Console.WriteLine(num1 + " is bigger than " + num2);
        }
    else
        {
        Console.WriteLine(num2 + " is bigger than " + num1);
        }
}

*/

// Задча №2 Напишите программу, которая принимает на вход три числа и выдаёт максимальное из этих чисел.
/*
int num1, num2, num3, max;

Console.WriteLine("Input first number: ");

num1 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input second number: ");

num2 = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input third number: ");

num3 = Convert.ToInt32(Console.ReadLine());

max = num1;

if (num2 > max)
{
    max = num2;
    if (num3 > max)
    {
        max = num3;
    }
}
else max = num1;

Console.WriteLine("Max number is: " + max);
*/

// Задача №3 Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).

/*
int a;

Console.WriteLine("Input number you want to check if it is even : ");

a = Convert.ToInt32(Console.ReadLine());

if (a % 2 == 0)
{
    Console.WriteLine("This number is even");
}
else
{
    Console.WriteLine("This number is odd");
}
*/

// Задча №4 Напишите программу, которая на вход принимает число (N), а на выходе показывает все чётные числа от 1 до N.

int N, current;

Console.WriteLine("Input any number and i will form a line of all even numbers from 1 to yours: ");

N = Convert.ToInt32(Console.ReadLine());


while (N <= 1)
{
    Console.WriteLine("Nice try, but try to input another number bigger than one! ");
    N = Convert.ToInt32(Console.ReadLine()); ;
}

Console.WriteLine("Look! I lined up all even numbers from 1 to " + N + ":");
current = 2;

while (current <= N)
{
    Console.Write(current + " ");
    current = current + 2; // current +=2;
}