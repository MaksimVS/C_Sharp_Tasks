//Напишите программу, которая на вход принимает 
//два числа и выдаёт, какое число большее, а какое меньшее.

int a, b, max, min;

Console.WriteLine("Введите первое число");
a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число");
b = Convert.ToInt32(Console.ReadLine());
if (a == b)
{
    Console.WriteLine("числа равны");
}
else
{
    if (a > b)
    {
        max = a;
        min = b;
    }
    else
    {
        max = b;
        min = a;
    }
    Console.WriteLine("max =  " + max );
    Console.WriteLine("min =  " + min);
}
