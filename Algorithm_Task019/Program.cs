//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.
//14212 -> нет
//12821 -> да
//23432 -> да

// 1. Создание массива нужного размера
int[] createArray(int size)
    {
        return new int [size];
    }

// 2. Задаем размер массива
int getNumber(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }

// 3.1 Заполнение массива пустыми ячейками 
string newEmptyArray (int[] emptyArray)
    {
        string result = String.Empty; // = пустая строка
        int len = emptyArray.Length;       // = длинна массива
        for (int index = 0; index < len; index++) // заполнение массива нужной длинны пустыми ячейками
            {
                result = result + " " + emptyArray[index];
            }
     return result;       
    }
  
// 3.2 Заполним пустой массив случайными числами
int newRandomArr (int[] randomArr)
    {
        Random random = new Random();
        int newResultRand = 0; 
        for (int i = 0; i < randomArr.Length - 1; i++)
            {
              newResultRand = random.Next(10);
              Console.Write(newResultRand + " ");
            }
       return newResultRand;
    }

//Заполним пустой массив вручную
int newManualArr (int[] manualArr)
    {
        int[] newResult = new int [manualArr.Length]; 
        Console.Write("Введите " + manualArr.Length + " элемента(ов) массива");
        for (int i = 0; i < newResult.Length; i++)
            {
               newResult[i] = int.Parse(Console.ReadLine());              
            }
        for (int i = 0; i < newResult.Length; i++)
            {
               Console.WriteLine(newResult[i]);              
            }
       return newResult[]; 
    }

//Проверка введенного числа на палиндром
bool checkPalindrom(string number)
    {
        if (number[0] == number[4] && number[1] == number[3])
            return true;
        else return false;
    } 

int size = getNumber("Введите размер массива ");  //по заданию можно ввести цифру 5
int[] numbers = createArray(size); //новый массив numbers принимает значение массива размером size
//Console.WriteLine(newEmptyArray(numbers)); //выводим на экран массив с нужным количеством пустых ячеек
//Console.WriteLine(newRandomArr(numbers)); //выводим на экран массив(заданного размера) из случайных чисел
Console.WriteLine(newManualArr(numbers));//выводим на экран массив(заданного размера) с введенными вручную числами





