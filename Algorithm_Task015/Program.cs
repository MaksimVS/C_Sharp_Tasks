// Напишите программу, которая принимает на вход цифру, 
//обозначающую день недели, и проверяет, является ли этот день выходным.

//6 -> да
//7 -> да
//1 -> нет

bool checkValue ()     // Метод оценивающий введенную, согласно задания, цифру
    {
        int value = 0;
        while (value < 1 || value > 7)
            {
                Console.WriteLine("Введите цифру от 1 до 7 обозначающую день недели");
                value = Convert.ToInt32(Console.ReadLine());
            }
        if (value >= 1 && value <= 5) return true;
        else return false;
    }

if (checkValue() == true) 
    {
        Console.WriteLine("Будничный день..."); 
    }
else Console.WriteLine("Выходной день...");    