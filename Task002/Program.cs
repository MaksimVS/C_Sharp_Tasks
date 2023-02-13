
// Напишите программу, которая принимает на вход три числа
// и выдаёт максимальное из этих чисел.
int a, b, c, max;

Console.WriteLine("Введите три числа");
a = Convert.ToInt32(Console.ReadLine());
b = Convert.ToInt32(Console.ReadLine());
c = Convert.ToInt32(Console.ReadLine());
if (a >= b)
{
    max = a;
    if (c >= a)
    {
        max = c;
    }
}
else
{
    max = b;
    if (c >= max)
    {
        max = c;
    }
}
Console.Write("Максимальное число = ");
Console.WriteLine(max);


