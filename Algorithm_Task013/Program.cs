// Напишите программу, которая выводит третью цифру заданного числа или сообщает,
// что третьей цифры нет.


Console.WriteLine("Введите число!");
int Value = Convert.ToInt32(Console.ReadLine());
checkNumber();

void checkNumber()           // Метод проверяет наличие третьей цифры и выдает ее, если находит 
    {
        if (Value < 100) 
                {
                Console.WriteLine("Третьей цифры нет!");
                }
        else
            {
            int thirdValue = prunningNumber() % 10;
            Console.WriteLine("Третья цифра числа = " + thirdValue);
            }
    }

int prunningNumber()         // функция(метод) обрезает лишние цифры
    {
      while (Value > 999) 
            {
             Value = Value / 10;
            }                 
     return Value;
    }  