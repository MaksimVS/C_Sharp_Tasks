// Напишите метод, который принимает на вход два числа (A и B) и возводит число A 
//в натуральную степень B. Нельзя использовать Math.Pow
//3, 5 -> 243 (3⁵)
//2, 4 -> 16

Console.WriteLine("Введите число необходимое возвести в степень");
int A = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число(степень)");
int B = Convert.ToInt32(Console.ReadLine());
Exponentiation(A);

int Exponentiation(int A)
{
    int value = A;
    int result = A;
    for (int i = 0; i < B - 1; i++) result = result * value;
    Console.WriteLine(result);
    return result;
}