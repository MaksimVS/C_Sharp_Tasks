// Напишите программу, которая на вход принимает число (N),
// а на выходе показывает все чётные числа от 1 до N.

int N, i;
Console.WriteLine("Введите положительное число");
N = Convert.ToInt32(Console.ReadLine());
i = 0;
int[] arr = new int[N];

arr[i] = 0;
while (i < N)
{
    arr[i] = i + 1;
    if (arr[i] % 2 == 0)
    {
        Console.Write(arr[i]);
        Console.Write(" ");
    }
    i = i + 1;
}


