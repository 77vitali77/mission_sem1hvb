// Задача 15: Напишите программу, которая принимает на вход цифру,
// обозначающую день недели, и проверяет, является ли этот день выходным.
Console.Write("Введи цифру, обозначающую день недели: ");
int dayNumber = Convert.ToInt32(Console.ReadLine());   // Ввод дня недели

void CheckingTheDayOfTheWeek (int dayNumber)   // метод
{
  if (dayNumber == 6 || dayNumber == 7)  // или (при совподении любого dayNumber выполняет 10 строку) совподает ли день с выходным 
  {
  Console.WriteLine("(этот день выходной) -> да");   // выводит в консоль
  }
  else if (dayNumber < 1 || dayNumber > 7) // или если не совподения от1 до7 хотябы одного из dayNumber выполняет 14 строку (еще есть && это полное совпадение одного и другого dayNumber)
  {
    Console.WriteLine("это вообще не день недели");
  }
  else Console.WriteLine("(этот день не выходной) -> нет"); // иначе от 1 до 5 будний день
}

CheckingTheDayOfTheWeek(dayNumber);   // метод в программе