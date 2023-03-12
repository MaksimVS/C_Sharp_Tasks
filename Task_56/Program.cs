//  Задайте прямоугольный двумерный массив. Напишите программу, 
//которая будет находить строку с наименьшей суммой элементов.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//5 2 6 7
//Программа считает сумму элементов в каждой строке и 
//выдаёт номер строки с наименьшей суммой элементов: 0 строка

void FillPrintTable(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            Console.Write($"{array[i, j]} ");
        }
        Console.WriteLine();
    }
}

int SumOfLineElements(int[,] array)
{
    int resultLine = 0;
    int result = 0;
    for (int i = 0; i < array.GetLength(0); i++)
    {
        int sum = 0;
        for (int j = 0; j < array.GetLength(1); j++)
        {
            sum = sum + array[i, j];
        }
        if (result < sum)
        {
            result = sum;
            resultLine = i;
        }
    }
    Console.WriteLine("Наибольшая сумма: " + result + " в строке с индексом: " + resultLine);
    return result;
}

Console.Write("введите число отображающее количество строк и столбцов ,,квадратного,, массива:  ");
int variable = Convert.ToInt32(Console.ReadLine());
int[,] numbers = new int[variable, variable];
FillPrintTable(numbers);
SumOfLineElements(numbers);
