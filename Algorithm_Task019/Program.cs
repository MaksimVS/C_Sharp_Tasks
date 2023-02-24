//Напишите программу, которая принимает на вход пятизначное число и проверяет, 
//является ли оно палиндромом.

//Написал код для проверки значений(числа или текста) любой длины  

Console.WriteLine("Введите число" + " ");
string number = Console.ReadLine();
checkPalindrom(number);


//Проверка введенного числа на палиндром
bool checkPalindrom(string number)
   {    
       for (int i = 0; i < (number.Length / 2); i++)
       {
        int j = (number.Length - 1) - i;
        if (number[i] != number[j]) 
            {
             Console.WriteLine("Число не является палиндромом!"); 
             return false;
            }
       }     
     Console.WriteLine("Это палиндром!");  
     return true;     
   } 







