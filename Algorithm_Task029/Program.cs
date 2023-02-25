// Напишите метод, который задаёт массив из N элементов и выводит их на экран.
//1, 2, 5, 7, 19 -> [1, 2, 5, 7, 19]
//6, 1, 33 -> [6, 1, 33]

int N = getNumber("Введите размер массива ");  //задаем размер массива
int[] numbers = createArray(N);

newRandomArr(numbers);

int[] createArray(int N)
{
    return new int[N];
}

int getNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int newRandomArr(int[] randomArr)
{
    Random random = new Random();
    int newResultRand = 0;
    for (int i = 0; i < randomArr.Length; i++)
    {
        newResultRand = random.Next(10);
        Console.Write(newResultRand + ", ");
    }
    return newResultRand;
}