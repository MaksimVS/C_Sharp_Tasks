// Напишите программу, которая принимает на вход трёхзначное число 
// и на выходе показывает вторую цифру этого числа.
// Используем функции (методы)

int enterNumber()         // функция(метод) с приглашением к вводу трехзначного числа
    {
        int Value = 0;
        while (!(Value > 99 && Value < 1000))
            {
                Console.WriteLine("Введите трехзначное число!");
                Value = Convert.ToInt32(Console.ReadLine());      
            }
        return Value;
    }

int secondValue = (enterNumber() / 10) % 10;
Console.WriteLine("Вторая цифра числа = " + secondValue);

        
// помучались как обычно с гит...
 
