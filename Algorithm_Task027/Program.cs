// Напишите метод, который принимает на вход число и выдаёт сумму цифр в числе.
//452 -> 11
//82 -> 10
//9012 -> 12

Console.Write("Введите число");
int number = Convert.ToInt32(Console.ReadLine());
Sum(number);

void Sum(int number)
{
    int sum = 0;
    while (number > 0)
    {
        int value = number % 10;
        number = number / 10;
        sum = sum + value;
    }
    Console.WriteLine(sum);
}