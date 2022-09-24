// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// d = √((xA - xB)^2 + (yA - yB)^2)
// Math.Round(),2 - оставить нужное кол-во знаков после запятой в десятичной дроби
// Math.Sqrt(),2 - квадратный корень
// Math.Pow(),2 - возведение в степень

// РЕШЕНИЕ ЧЕРЕЗ МАССИВ

Console.WriteLine("Введите координаты первой точки ");
string[] values = Console.ReadLine().Split(new char[] { ',' });
int x1 = int.Parse(values[0]);
int y1 = int.Parse(values[1]);

Console.WriteLine("Введите координаты второй точки ");
string[] values_2 = Console.ReadLine().Split(new char[] { ',' });
int x2 = int.Parse(values_2[0]);
int y2 = int.Parse(values_2[1]);

double result = Math.Round(Math.Sqrt(Math.Pow(x1 - x2, 2) + Math.Pow(y1 - y2, 2)), 2);
Console.WriteLine($"Расстояние между двумя точками в 2D равно: {result}");
