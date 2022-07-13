
string[] CreateStringArray(int size)
{
    string[] words = new string[size];

    for (int i = 0; i < size; i++)
    {
        Console.Write($"Input {i + 1} words: ");
        words[i] = Console.ReadLine();
    }

    return words;
}

void ShowArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
        Console.Write(array[i] + " ");

    Console.WriteLine();
}

//Задача 1: Задайте массив строк. Напишите программу, считает кол-во слов в массиве, начинающихся на гласную букву.
//Пример: { "qwe", "wer", "ert", "rty", "tyu"} -> 1

int AmountOfWordsStartingFromVowel(string[] array)
{
    int count = 0;
    for (int i = 0; i < array.Length; i++)
    {
        char Vowel = array[i].ToLower()[0];
        if (Vowel == 'a' || Vowel == 'e' || Vowel == 'i' || Vowel == 'o' || Vowel == 'u' || Vowel == 'y')
            count++;
    }
    return count;
}
/*
Console.WriteLine("This algorythm is to count words starting with the wovel letter");
Console.WriteLine("Input how many words you want to check: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = CreateStringArray(size);

Console.WriteLine($"There are {AmountOfWordsStartingFromVowel(array)} words starting with the vowel.");
*/
//Задача 2: Задайте массив строк. Напишите программу, которая генерирует новый массив, объединяя элементы исходного массива попарно.
//Пример: { "qwe", "wer", "ert", "rty", "tyu", "yui"} -> { "qwewer", "ertrty", "tyuyui"}

string[] ArrayConverging(string[] array)
{
    int size = array.Length / 2;
    //if (array.Length % 2 == 1) 
    //size = array.Length/2 + 1;
    //else size = array.Length/2;

    string[] NewArray = new string[size];

    for (int i = 0; i < size; i++)
    {
        NewArray[i] = array[i * 2] + array[i * 2 + 1];
    }

    return NewArray;
}

//string [] array = { "AB", "BA", "L", "P", "Limp", "Bizkit", "Nirvana"};
//ShowArray(array);
//Console.WriteLine(array.Length);

//string [] MyArray = ArrayConverging(array);
//ShowArray(MyArray);

Console.WriteLine("This algorythm is merging two string array pairwise");
Console.WriteLine("Input how many words you want your array to contain: ");
int size = Convert.ToInt32(Console.ReadLine());

string[] array = CreateStringArray(size);
string[] MyArray = ArrayConverging(array);
Console.WriteLine();
Console.WriteLine($"Here is merged array: ");
ShowArray(MyArray);
if (array.Length % 2 == 1) Console.WriteLine($"The element '{array[array.Length - 1]}' doesn't have pair to merge with");




