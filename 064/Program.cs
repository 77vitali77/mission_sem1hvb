// Задача 63: Задайте значение вещественное N. Напишите программу, 
// которая выведет все натуральные числа в промежутке от N до 1.Выполнить с помощью рекурсии


double GetNumberFromConsole()
 {
     return Convert.ToDouble(Console.ReadLine());
 }
 

int a = 1;
string WriteNumbersRecursion(double lastNumber, int a)
 {
     if (lastNumber >= a)
        return lastNumber + ", " + WriteNumbersRecursion(lastNumber-1, a);
    
    return string.Empty;
 }



double number = GetNumberFromConsole();

Console.Write(WriteNumbersRecursion(number,a));

