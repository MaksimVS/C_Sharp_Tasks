// Напишите программу, которая принимает на вход число (N) и 
//выдаёт таблицу кубов чисел от 1 до N.
//3 -> 1, 8, 27
//5 -> 1, 8, 27, 64, 125

Console.WriteLine("Введите число");
int N = Convert.ToInt32(Console.ReadLine());
Cube(N);

void Cube(int N)
{
    int column = 0;
    for (column = 0; column < 10; column++)
        Console.Write("   " + column);
    Console.WriteLine();
    int str = 0;
    column = 0;
    Console.Write(str);

    for (int i = 0; i < N; i++, column++)
    {
        if (column < 10)
        {
            int number = i * i * i;
            Console.Write("  " + number);        
        }
        else 
        {
            Console.WriteLine();
            str++;
            Console.Write(str);
            int number = i * i * i;
            Console.Write("  " + number);
            column = 0;       
        }
    }

}

