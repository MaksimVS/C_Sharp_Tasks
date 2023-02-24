// Пробуем вывод массива(заполненного разными способами) на экран через метод


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

// 3.3 Заполним пустой массив вручную - НЕ ПОЛУЧАЕТСЯ ВЫВЕСТИ ВСЕ ЭЛЕМЕНТЫ РАЗОМ ПОСЛЕ ВВОДА
int[] newManualArr (int[] manualArr) 
    { 
        Console.WriteLine("Введите " + manualArr.Length + " элемента(ов)" + " ");
        for (int i = 0; i < manualArr.Length; i++)
            {
              manualArr[i] = Convert.ToInt32(Console.ReadLine()); 
            }            
      return manualArr; //???
    }

int size = getNumber("Введите размер массива ");  //задаем размер массива
int[] numbers = createArray(size); //новый массив numbers принимает значение массива размером size
//Console.WriteLine(newEmptyArray(numbers)); //выводим на экран массив с нужным количеством пустых ячеек
//Console.WriteLine(newRandomArr(numbers)); //выводим на экран массив(заданного размера) из случайных чисел
Console.WriteLine(newManualArr(numbers));//выводим на экран массив(заданного размера) с введенными вручную числами
