﻿//Задача 13: Напишите программу, которая выводит третью цифру
// заданного числа или сообщает, что третьей цифры нет.

int CriateNuber()
{
    int number = new Random().Next(1,100);// выбирает случайное число из отрезка от100до1000
    return number;// возвращает результат 
}


int threeDigit(int number)
{
     if(number > 99) // все что меньше 99 нас не интересует
     {
      number = (number / 100) % 10; //делим на 100 остаток от деления и есть наша цифра
     }
     else  // иначе число меньше чем трехзначное
     {
      Console.WriteLine("третьей цыфры в чесле нет"); //выводим в консоль
     }
     
    return number;//возвращяет третье число в заданном или число меньше чем трехзначное
}
    

int a = CriateNuber();//присваеваем переменной a 
Console.WriteLine(a);// выводим в консоль 
int number = threeDigit(a);// производит вычеслительные действия
Console.WriteLine(number);// выводит в консоль ответ 



