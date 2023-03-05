//Пользователь вводит с клавиатуры M чисел. 
//Посчитайте, сколько чисел больше 0 ввёл пользователь.
//0, 7, 8, -2, -2 -> 2
//1, -7, 567, 89, 223-> 3

int[] CreateArray(int size){return new int [size];}

int GetNumber(string text)
    {
        Console.WriteLine(text);
        return Convert.ToInt32(Console.ReadLine());
    }        
    
string NewManualArr (int[] manualArr) 
    { 
        Console.WriteLine("Введите " + manualArr.Length + " элемента(ов)" + " ");
        for (int i = 0; i < manualArr.Length; i++)
            {
              manualArr[i] = Convert.ToInt32(Console.ReadLine()); 
            }            
        string result = String.Join(", ", manualArr);
      return result;
    }

void CheckNumbers (int[] manualArr)
    {
        int counter = 0;
        for (int i = 0; i < manualArr.Length; i++){if (manualArr[i] > 0){counter++;}}        
      Console.WriteLine("чисел больше нуля : " + counter);
    }

int size = GetNumber("Введите размер массива ");  
int[] numbers = CreateArray(size); 
Console.WriteLine(NewManualArr(numbers));
CheckNumbers(numbers);
