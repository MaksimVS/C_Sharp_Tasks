// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N. Сделал при N <= 100, 
//для использования табличного стиля
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Таблица кубов чисел от 1 до " + N + ": ");
int column = 0;
for (column = 0; column < 10; column++)
    Console.Write("      " + column);
Console.WriteLine();
column = 0;
int i = 0;

Construction();

void Construction()
{
    int str = 0;
    Console.Write(str);
    for (str = 0, i = 0; str < 10 && i < N; i++, column++)
    {
        if (column < 10) Cube(N);
        else
        {
            Console.WriteLine();
            str++;
            Console.Write(str);
            Cube(N);
            column = 0;
        }
    }
}
void Cube(int N)
{
    int number = i * i * i;
    if (number < 10) Console.Write(" " + "00000" + number);
    else if (number < 100) Console.Write(" " + "0000" + number);
    else if (number < 1000) Console.Write(" " + "000" + number);
    else if (number < 10000) Console.Write(" " + "00" + number);
    else if (number < 100000) Console.Write(" " + "0" + number);
    else Console.Write(" " + number);
}


