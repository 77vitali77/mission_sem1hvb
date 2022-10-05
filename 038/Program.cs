﻿// Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и
// минимальным элементов массива.


void FillArrayRandomNumbers(double[] numbers)
{
    for(int i = 0; i < numbers.Length; i++)
        {
            numbers[i] = Convert.ToDouble(new Random().Next(100,1000)) / 10;
        }
}
void PrintArray(double[] numbers)
{
    Console.Write("[ ");
    for(int i = 0; i < numbers.Length; i++)
        {
            Console.Write(numbers[i] + ": ");
        }
    Console.Write("]");
    Console.WriteLine();
}

Console.WriteLine("Введите размер массива");
int siie = int.Parse(Console.ReadLine());
double[] numbers = new double[siie];
FillArrayRandomNumbers(numbers);
PrintArray(numbers);
double min = Int32.MaxValue;
double max = Int32.MinValue;

for (int i = 0; i < numbers.Length; i++)
{
    if (numbers[i] > max)
        {
            max = numbers[i];
        }
    if (numbers[i] < min)
        {
            min = numbers[i];
        }
}

Console.WriteLine($"всего {numbers.Length} чисел. Максимальное значение = {max}, минимальное значение = {min}");
Console.WriteLine($"Разница между максимальным и минимальным элементами  = {max - min}");