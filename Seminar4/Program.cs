// 
/* int Summa (int a)
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
Console.WriteLine("Enter your ")
*/ 

void Countofdigits(int a)
{
    int counter = 0;
    while (a > 0)
    {
        a = a / 10;
        counter = counter + 1;
    }
    Console.WriteLine("Count of digits in your number is: " + counter);
}
int a = Convert.ToInt32(Console.ReadLine());
Countofdigits(a);