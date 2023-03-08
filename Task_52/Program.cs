// Задайте двумерный массив из целых чисел. Найдите среднее арифметическое элементов в каждом столбце.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//Среднее арифметическое каждого столбца: 4,6; 5,6; 3,6; 3.

void Calculator(int[,] array)
{
    int sum = 0;
    double calk = 0;
    System.Console.WriteLine($" Среднее арифметическое столбцов равно: ");
    for(int i = 0; i<array.GetLength(1);i++)
    {
        for(int j = 0; j<array.GetLength(0); j++)
        { 
            sum = sum + array[j,i];
        }
        calk = Convert.ToDouble(sum)/(array.GetLength(0));
        System.Console.WriteLine($"{i+1} = {calk}");
        sum = 0;
    }
}
void FillTable(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(0, 10);
            System.Console.Write($"{array[i, j]} ");
        }
        System.Console.WriteLine();
    }
}

int[,] numbers = new int[5, 3];
FillTable(numbers);
Calculator(numbers);