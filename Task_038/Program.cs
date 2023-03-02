// Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3 7 22 2 78] -> 76

double[] createArray(int size)
{
    return new double[size];
}

int getNumber(string text)
{
    Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void newRandomArr(double[] randomArr)
{
    Random random = new Random();
    
    for (int i = 0; i < randomArr.Length; i++)
    {
        randomArr[i] = Math.Round(random.NextDouble()*100,2);
        Console.Write(randomArr[i] + "   ");
    }
}
 
double[] numbers = createArray(getNumber("Введите размер массива "));
newRandomArr(numbers);
double min = MinNum(numbers);
double max = MaxNum(numbers);
Console.WriteLine(" ");
Console.WriteLine("min = " + min);
Console.WriteLine("max = " + max);
Difference(max,min);

double MinNum(double[] Arr)
{
    double min = Arr[0];
    for (int i = 0; i < Arr.Count(); i++)
    {
        if (min > Arr[i]) min = Arr[i];
    }
    return min;
}

double MaxNum(double[] Arr)
{
    double max = Arr[0];
    for (int i = 0; i < Arr.Count(); i++)
    {
        if (max < Arr[i]) max = Arr[i];
    }
    return max;
}

double Difference(double max, double min)
    {
        double result = max - min;
        Console.WriteLine("max - min = " + result);
        return result; 
    }