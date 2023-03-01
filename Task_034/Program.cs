// Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

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
        newResultRand = random.Next(100, 1000);
        Console.Write(newResultRand + " ");
        if (newResultRand % 2 == 0) count++;
    }
    Console.Write("четных чисел: " + count + " ");
}

int size = getNumber("Введите размер массива ");
int[] numbers = createArray(size);
newRandomArr(numbers);
