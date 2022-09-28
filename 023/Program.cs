//Задача 23: Напишите программу, которая принимает на вход число (N)
// и выдаёт таблицу кубов чисел от 1 до N.


Console.Write("Введите число N: ");   // Вводим число N
int cube = Convert.ToInt32(Console.ReadLine());   //конвертируем и присваеваем

void Cube(int[] cube)   //метод возведения в куб
{
  int length = cube.Length;
  for (int counter = 0; counter <  length; counter++)
  {
    cube[counter] = Convert.ToInt32(Math.Pow(counter, 3));    
  }
}

void PrintArry(int[] coll)   //метод печати массива в консоль
{
  int count = coll.Length;  
  for (int index = 0; index < count; index++)
  {
    Console.Write(coll[index]+ " ");    
  }
} 

int[] arry = new int[cube+1];   //заплняем массив через Вводим число N
Cube(arry);   //возводим в куб массив
PrintArry(arry);   // печать массива в консоль