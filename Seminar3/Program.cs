// Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, в которой находится эта точка.
/*
int FindQuart(int x, int y)
{
    if (x > 0 && y > 0) Console.WriteLine1;
    if (x < 0 && y > 0) Console.WriteLine2;
    if (x < 0 && y < 0) Console.WriteLine3;
    if (x > 0 && y < 0) Console.WriteLine4;

    Console.WriteLine-1;
}

Console.WriteLine("Input X-axis coordinate: ");
int x = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input Y-axis coordinate: ");
int y = Convert.ToInt32(Console.ReadLine());

int result = FindQuart(x, y);

if (result == -1) Console.WriteLine("This point lie on the axes");
else Console.WriteLine($"This point belongs to {result} quarter");
*/
// Напишите программу, которая по заданному номеру четверти, показывает диапазон возможных координат точек в этой четверти (x и y).
/*
void QuartRange(int num)
{
    if (num == 1) Console.WriteLine("x > 0, y > 0");
    if (num == 2) Console.WriteLine("x < 0, y > 0");
    if (num == 3) Console.WriteLine("x < 0, y < 0");
    if (num == 4) Console.WriteLine("x > 0, y < 0");
    
    else Console.WriteLine("There is no such quarter. Input number from 1 to 4");
}

Console.WriteLine("Input number of the quarter: ");
int num = Convert.ToInt32(Console.ReadLine());

QuartRange(num);
*/

// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу квадратов чисел от 1 до N.
/*
void LineOfQuads(int num)
{
    int current = 1;
    if (num < 0) num = num * -1;
        while (current <= num)
        {
            Console.Write(current * current + " ");
            current++;
        }

}

Console.WriteLine("Input number: ");
int num = Convert.ToInt32(Console.ReadLine());

LineOfQuads(num);
*/

// Написать программу, которая принимает координаты двух точек и находит расстояние между ними

double FindLenght(double xA, double yA, double xB, double yB)
{
    return Math.Sqrt(xB - xA * (xB - xA) + Math.Pow((yB - yA), 2));
}

Console.WriteLine("Input coordinates of the first point");
Console.WriteLine("X-axis: ");
double xA = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y-axis: ");
double yA = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Input second point coordinates");
Console.WriteLine("X-axis: ");
double xB = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Y-axis: ");
double yB = Convert.ToDouble(Console.ReadLine());

double result = FindLenght(xA, yA, xB, yB); 
Console.WriteLine(result); 

