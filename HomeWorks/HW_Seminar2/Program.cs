// Задача №1: Напишите программу, которая принимает на вход трёхзначное число и на выходе показывает вторую цифру этого числа.

//456 -> 5
//782 -> 8
//918 -> 1
/*
int FindSecondDigit(int num)

{
    int second, twodigit;

        if (num >= 100 && num <= 999) 
        {
            twodigit = num / 10;
            second = twodigit % 10;
            return second;
        }
        else 
        {
            return -1;
        }
}

Console.WriteLine("input three-digit number: ");

int a = Convert.ToInt32(Console.ReadLine());

if(a < 0)
{
    a = -a;
}

int result = FindSecondDigit(a);

if (result == -1)
{
    Console.WriteLine("Yout number is not a three-digit number. Try another one");
}
else
{
    Console.WriteLine(result);
}
*/

//Задача №2: Напишите программу, которая выводит третью цифру заданного числа или сообщает, что третьей цифры нет.

//645 -> 5

//78 -> третьей цифры нет

//32679 -> 6
/*
int FindThirdDigit (int num)
{
    int third;

    if (num >= 0 && num <=99)
    {
        Console.WriteLine("there is no third digit in your number");
        return -1;
    }
    else
    {
        while (num > 999)
        {
            num = num / 10;
        }
        third = num % 10;
        return third;
    }
}

 Console.WriteLine("input any number: ");

 int a = Convert.ToInt32(Console.ReadLine());

 if (a < 0)
 {
     a = -a;
 }

 int result = FindThirdDigit(a); 

 if (result == -1)
 {
     Console.WriteLine("Try another one");
 }
 else
 {
     Console.WriteLine("The third digit in your number is " + result);
 }

*/


// Задача №3: Напишите программу, которая принимает на вход цифру, обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет
/*
int WeekEnd (int day)
{
    if (day == 6 ^ day == 7) return 1;
    else return 0; 
}

Console.WriteLine("Input number of the day of the week: ");

int WeekDay = Convert.ToInt32(Console.ReadLine());

if (WeekDay >= 1 && WeekDay <= 7)
{
    int result = WeekEnd(WeekDay);
    
    if (result == 1)
    {
        Console.WriteLine("Hooraay! It's Weekend");
    } 
    
    if (result == 0)
    {
        Console.WriteLine("I'm sorry but it's just a week day");
    }
}
else
{Console.WriteLine("There is only seven days in a week. Restart the programm and input the number from 1 to 7, where 1 is Monday");}
*/

void WeekEnd(int day)
{
    if(day == 1) Console.WriteLine("I'm sorry it's only Monday, the whole week is ahead");
    
    if(day == 2) Console.WriteLine("It's Tuesday. There are four days to the weekend");
    
    if(day == 3) Console.WriteLine("Wednesday is a small Friday, half of the week is in the past");
    
    if(day == 4) Console.WriteLine("It's Thursday, be pationed, you're two days to the weekend");
    
    if(day == 5) Console.WriteLine("Friday again, you're on home straight. Tomorrow is the weekend");
    
    if(day == 6) Console.WriteLine("Congratualtions! How are you going to spend your weekend?");
    
    if(day == 7) Console.WriteLine("Sunday. Use this day wisely and remeber Monday is tomorrow");
    
    if(day < 1 && day > 7) Console.WriteLine("There is only seven days in a week. Restart the programm and input the number from 1 to 7, where 1 is Monday");
}

Console.WriteLine("Input number of the day of the week: ");

int WeekDay = Convert.ToInt32(Console.ReadLine());

WeekEnd(WeekDay); 

//Задачи реализуем в виде методов :)