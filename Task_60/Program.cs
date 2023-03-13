// Сформируйте трёхмерный массив из неповторяющихся двузначных чисел. 
//Напишите программу, которая будет построчно выводить массив, добавляя индексы каждого элемента.
//Массив размером 2 x 2 x 2
// 66(0,0,0) 25(0,1,0)
// 34(1,0,0) 41(1,1,0)
// 27(0,0,1) 90(0,1,1)
// 26(1,0,1) 55(1,1,1)
//Создам квадратный массив для простоты ввода размера, при желании, 
//легко заменить значение variable на три разных числа. 

void FillPrintTable3D(int[,,] array3D)
{
    int[] array1D = new int[90];
    int m = 0;
    for (int i = 0; i < array3D.GetLength(0); i++)
    {
        for (int j = 0; j < array3D.GetLength(1); j++)
        {
            Console.WriteLine();
            for (int k = 0; k < array3D.GetLength(2);)
            {
                array3D[i, j, k] = new Random().Next(10, 100);
                for (m = 0; m < array1D.Length; m++)
                {
                    if (array1D[m] == 0)
                    {
                        Console.Write($"{array3D[i, j, k]}({i},{j},{k}) ");
                        array1D[m] = array3D[i, j, k];
                        k++;
                        break;
                    }
                    else if (array1D[m] != 0 && array1D[m] == array3D[i, j, k])
                    {
                        break;
                    }
                }
            }
        }
    }
}


Console.Write("введите число отображающее количество строк и столбцов ,,квадратного,, массива:  ");
int variable = Convert.ToInt32(Console.ReadLine());
if (variable * variable * variable <= 90)
{
    int[,,] numbers = new int[variable, variable, variable];
    FillPrintTable3D(numbers);
}
else Console.WriteLine("Количество элементов массива превышает количество двузначных неповторяющихся чисел (90 элементов)! Уменьшите массив!");
