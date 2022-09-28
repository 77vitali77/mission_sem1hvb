// Задача 21: Напишите программу, которая принимает на вход координаты
// двух точек и находит расстояние между ними в 3D пространстве.

int x1 = Coordinate("x", "A");  //Вводим координаты точек
int y1 = Coordinate("y", "A");
int z1 = Coordinate("z", "A");
int x2 = Coordinate("x", "B");
int y2 = Coordinate("y", "B");
int z2 = Coordinate("z", "B");

int Coordinate(string coorName, string pointName) // метод введения координат точек
{
    Console.Write($"Введите координату {coorName} точки {pointName}: ");   //вводим координаты точки
    return Convert.ToInt16(Console.ReadLine());   // возвращяем результат
}

double Decision(double x1, double x2, // метод решения растояния между точками А и В
                double y1, double y2, 
                double z1, double z2)
{
  return Math.Sqrt(Math.Pow((x2-x1), 2) + //возвращяем результат вычислений координаты по х в квадрате
                   Math.Pow((y2-y1), 2) + //координаты по у в квадрате
                   Math.Pow((z2-z1), 2)); //координаты по z в квадрате
}

double segmentLength =  Math.Round (Decision(x1, x2, y1, y2, z1, z2), 2 );  //производим вычесления

Console.WriteLine($"Длина отрезка  {segmentLength}");  //Выводим результат в консоль
