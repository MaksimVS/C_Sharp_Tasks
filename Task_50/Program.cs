// Напишите программу, которая на вход принимает позиции элемента в двумерном массиве, и возвращает значение этого элемента или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//1, 7 -> такого числа в массиве нет

void FillTable(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(100) - 25;
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}
void FindNumber(int[,] array, int m, int n)
{
    if (m < array.GetLength(0))
    {
        if (n < array.GetLength(1)) System.Console.Write($"число: {array[m, n]}");
        else System.Console.WriteLine("Число не найдено, нет такого столбца");
    }
    else System.Console.WriteLine("Число не найдено, нет такой строки");
}

int GetNumber(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int[,] table = new int[4, 5];
FillTable(table);
FindNumber(table, GetNumber("Введите строку"), GetNumber("Введите столбец"));