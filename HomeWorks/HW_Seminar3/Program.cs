/* Задача №1 Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

14212 -> нет
12821 -> да
23432 -> да 
*/
/*
void Palidnrome(int num)
{
if (num < 0) 
    {
        num = num * -1;
        Console.WriteLine($"I assume you wanted to type {num},");
    }
if (num < 10000 ^ num > 99999) Console.WriteLine("Wrong number. Try another one which is 5-digit number");
else
    {
        int i = num / 10000;
        int ii = (num / 1000) % 10;
        int iii= (num / 100) % 10;
        int iv = (num / 10) % 10;
        int v = num % 10;
    if (i==v && ii==iv) Console.WriteLine("Yes, that's a good example of a palindrome");
    else Console.WriteLine("No, it is not a palindrome");
    }
}


Console.WriteLine("Palindrome is a number which reads the same backward as forward." + "Input 5-digit number you want to check if it is a palindrome: ");
string number = (Console.ReadLine());
    if (number == "00000") 
    {
        Console.WriteLine("Yes, that's a palindrome too"); 
        Environment.Exit(0);
    }

int num = Convert.ToInt32(number);

Palidnrome(num);
*/

//Задача №2 Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

//A (3,6,8); B (2,1,-7), -> 15.84
//A (7,-5, 0); B (1,-1,9) -> 11.53

/*
double FindLenght(double xA, double yA, double zA, double xB, double yB, double zB)
{
    return Math.Sqrt(Math.Pow((xB - xA), 2) + Math.Pow((yB - yA), 2) + Math.Pow((zB - zA),2));
}

Console.WriteLine("Input coordinates of the first point");
Console.WriteLine("X-axis: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y-axis: ");
double yA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Z-axis: ");
double zA = Convert.ToDouble(Console.ReadLine());


Console.WriteLine("Input second point coordinates");
Console.WriteLine("X-axis: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y-axis: ");
double yB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Z-axis: ");
double zB = Convert.ToDouble(Console.ReadLine());


double result = FindLenght(xA, yA, zA, xB, yB, zB);

Console.WriteLine($"The length between two points is: {Math.Round(result,2)}"); 
*/

//Задача №3 Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125
/*
void LineOfCubes(int num)
{
    int current = 1;
    
    if (num > 0)
        while (current <= num)
        {
            Console.Write(Math.Pow(current, 3) + " ");
            current = current +1;
        }
    
    if (num == 0) Console.WriteLine(0);
    
    if (num < 0)
        while (current >= num)
        {
            Console.Write(Math.Pow(current, 3) + " ");
            current = current - 1;
        }
    

}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

LineOfCubes(num);
*/
