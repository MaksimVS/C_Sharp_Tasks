// Задайте двумерный массив размером m×n, заполненный случайными вещественными числами.
//m = 3, n = 4.
//0,5 7 -2 -0,2
//1 -3,3 8 -9,9
//8 7,8 -7,1 9

double[,] FillArray(int m, int n)
{
    double [,] array = new double[m, n];
    Random rand = new Random();
    for (int i = 0; i < m; i++)
    {
        for (int j = 0; j < n; j++)
        {
            array[i, j] = Math.Round(rand.Next(-100, 101)*0.1, 1);
            System.Console.Write(array[i, j] + "|  ");
        }
        System.Console.WriteLine();
    }
    return array;
}

FillArray(3,4);