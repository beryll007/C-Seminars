//string [] names = {"Anna", "Danil", "Alisa", "Alexey"};

//Console.WriteLine(names[0][1]);

// Программа, которая на вход берет массив строк, а на выход получает количество слов, длина которых более пяти символов.

string [] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i+1} words: ");
        words [i] = Console.ReadLine();
    }

    return words;
}

void ShowArray (string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

int NumberOfLongWords (string[]array)
{
    int count = 0;

    for (int i =0; i < array.Length; i++)
        if (array[i].Length > 5)
            count ++;

    return count;
}
/*
Console.Write("Input number of names: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] names = CreateStringArray(size);

Console.WriteLine("There are " + NumberOfLongWords(names) + " long words among your names");
*/


//Задача №1. Написать программу, которая принимает на вход два массива строк и 
//возвращает массив из попарно объединенных исходных элементов.

string [] ArrayCombiantion (string [] arrayOne, string [] arrayTwo)
{
    int size;
    if (arrayOne.Length > arrayTwo.Length) 
        {size = arrayTwo.Length;
            for (int i = 0; i < size; i++)
            {
                arrayOne[i] = arrayOne[i] + arrayTwo[i];
            }
            return arrayOne;
        }
    
    
    else size = arrayOne.Length;
    {
        for (int i = 0; i < size; i++)
        {
            arrayTwo[i] = arrayTwo[i] + " " + arrayOne[i];
        }
        return arrayTwo;
    }
    
}
    
    
//string [] arrayOne = {"ab","bb","cb","db"};
//string [] arrayTwo = {"12","23","45"};
/*
Console.Write("Input number of words in the first array: ");
int sizeOne = Convert.ToInt32(Console.ReadLine());
string[] arrayOne = CreateStringArray(sizeOne);

Console.Write("Input number of words in the second array: ");
int sizeTwo = Convert.ToInt32(Console.ReadLine());
string[] arrayTwo = CreateStringArray(sizeTwo);

ShowArray(ArrayCombiantion(arrayOne, arrayTwo));
*/

//Задача №2 Написать программу, которая считает кол-во слов, начинающихся на букву Y или W.

int CountWordsWithSymbols (string[] array, char SymbOne, char SymbTwo)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i][0] == SymbOne || array[i][0] == SymbTwo) 
        count ++;
    }
    return count;
}

Console.WriteLine("Input the size of array: ");
int size = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Input first symbol: ");
char SymbOne = Convert.ToChar(Console.ReadLine());

Console.WriteLine("Input second symbol: ");
char SymbTwo = Convert.ToChar(Console.ReadLine());

string[] array  = CreateStringArray(size);
Console.WriteLine(" " + CountWordsWithSymbols(array, SymbOne, SymbTwo));






