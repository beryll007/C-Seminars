
/* 
c = a % b 
5 % 2 -> 1 отделяем остаток
5 / 2 -> 2 деление без остатка

 1234 / 10 -> 123 % 10 -> 3
 1234 % 10 -> 4
 1234 % 100 -> 34
 1234 / 100 -> 12 
 
 */

/* 
 int FindMaxPart(int num)

{
    int dec, ed;

    if (num >= 10 && num <= 99) // && - логическое "И" 
    {
        dec = num / 10;
        ed = num % 10;

        if(dec > ed)
        {
            return dec;
        }
        else
        {
            return ed;
        }
    }
    else 
    {
        return -1;
    }
}

Console.Write("Input two-digit number: ");
int a = Convert.ToInt32(Console.ReadLine());

int result = FindMaxPart(a);

if(result == -1)
{
    Console.WriteLine("Your number is not a two-digit number");
}
else
{
Console.WriteLine($"Bigger number of {a} is {result}"); // применили форматирование
}
*/

/* 1. Написать программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа.

int CutNumber()
{
    int num = new Random().Next(100, 1000);
    Console.WriteLine($"Current number is {num}");

    int sot = num / 100;
    int ed = num % 10;

    return sot * 10 + ed;
}

Console.WriteLine(CutNumber());
/*
2. Напишите программу, которая будет принимать на вход два числа и выводить, 
является ли второе число кратным первому. 
Если второе число не кратно числу первому, 
то программа выводит остаток от деления.

string IsAliquot(int num1, int num2)
{
    if(num2 % num1 == 0)
    {
        return "True"; 
    }
    else
    {
        return("False, rest num is "+ (num2 % num1));
    }
}
*/

/*
3. Напишите программу, которая принимает на вход число и проверяет, 
кратно ли оно одновременно 7 и 23.
*/

bool IsAliquot2(int num)
{
    if(num % 23*7 == 0) return true; // if(num % 23 ==0 && num % 7 == 0) return true
    else return false;
}

