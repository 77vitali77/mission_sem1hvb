//  Напишите программу, которая задаёт массив из 8 элементов 
//и выводит их на экран.

int[] array = {3,2,1,6,4,5,8,7};

void printArray(int[] array)
{
  int count = array.Length;
  for (int i = 0; i < count; i++)
  {
    Console.Write($"{array[i]} ");
  }
  Console.WriteLine();
}
printArray(array);
