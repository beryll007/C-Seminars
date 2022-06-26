int[] ReverseArray(int[] array)    // Метод на разворот массива
{
    int temp;
    int j = array.Length - 1, i = 0;

    while (i < j)
    {
        temp = array[i];
        array[i] = array[j];
        array[j] = temp;

        i++;
        j--;
    }
    return array;
}
/*
    for (int i =0; i < arrat.Lenght / 2; i++, j--)
    {
        temp = array [i];
        array [i] = array [j];
        array[j] = temp;
    }
    return array;
}
*/
/*
int[] myArray = { 2, 4, 6, 8, 16 };
myArray = ReverseArray(myArray);

for (int i = 0; i < myArray.Length; i++)
{
    Console.Write(myArray[i] + " ");
}
*/
// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник со сторонами такой длины.

void Triangle(int a, int b, int c)
{
    if ((a + b) > c && b + c > a && c + a > b) Console.WriteLine("Such triangle can exist");
    else Console.WriteLine("Such triangle couldn't exist");
}

/*
int a = 3;
int b = 4;
int c = 5;

Triangle(a,b,c);
*/

// Не используя рекурсию, выведите превые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1

void Fibonacci(int n)
{
    int[] array = new int[n];
    array[0] = 0;
    array[1] = 1;
    Console.Write(array[0] + " " + array[1] + " ");

    for (int i = 2; i < n; i++)
    {
        array[i] = array[i - 1] + array[i - 2];
        Console.Write(array[i] + " ");
    }
}

//int n = 7;
//Fibonacci(n);

// Написать программу, которая будет преобразовывать десятичное число в двоичное.

string BinaryNumber(int num)
{
    string result = string.Empty;

    while (num > 0)
    {
        result = num % 2 + result;
        num /= 2;
    }
    return result;
}

Console.WriteLine(BinaryNumber(10)); 