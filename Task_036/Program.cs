//Задайте одномерный массив, заполненный случайными числами.
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19
//[-4, -6, 89, 6] -> 0

int[] createArray(int size)
{
    return new int[size];
}

int getNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void newRandomArr(int[] randomArr)
{
    Random random = new Random();
    int count = 0;
    int newResultRand = 0;
    for (int i = 0; i < randomArr.Length; i++)
    {
        newResultRand = random.Next(10);
        Console.Write(newResultRand + " ");
        if (i % 2 != 0)
        {
            count = count + newResultRand;
        }
    }
   Console.Write(" " + count);
}

int size = getNumber("Введите размер массива ");
int[] numbers = createArray(size);
newRandomArr(numbers);