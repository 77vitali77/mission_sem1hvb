// Задача 10: Напишите программу, которая принимает на вход трёхзначное число
//и на выходе показывает вторую цифру этого числа.

int CriateNuber()
{
    int number = new Random().Next(100,1000);// выбирает случайное число из отрезка от100до1000
    return number;// возвращает результат пример 380
}


int threeDigit(int number)
{
     number = number / 10;// трехзначное делим на 10 (380/10=38)
     number = number % 10;// остаток от деления (38/10 = 8)
    
    return number;//возвращяет 8
}
int a = CriateNuber();//присваеваем переменной a 380
Console.WriteLine(a);// выводим в консоль 380
int number = threeDigit(a);// производит вычеслительные действия
Console.WriteLine(number);// выводит в консоль ответ 8
