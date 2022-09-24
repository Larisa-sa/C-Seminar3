// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 2D пространстве.
// A (3,6); B (2,1) -> 5,09
// A (7,-5); B (1,-1) -> 7,21
// d = √((xA - xB)^2 + (yA - yB)^2)
// Math.Round(),2 - оставить нужное кол-во знаков после запятой в десятичной дроби
// Math.Sqrt(),2 - квадратный корень
// Math.Pow(),2 - возведение в степень

Console.WriteLine("Введите координату X первой точки: ");
int x1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y первой точки: ");
int y1 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату X второй точки: ");
int x2 = int.Parse(Console.ReadLine());

Console.WriteLine("Введите координату Y второй точки: ");
int y2 = int.Parse(Console.ReadLine());

Console.WriteLine($"Длина отрезка = {Math.Round(Math.Sqrt(Math.Pow((x1-x2),2) + Math.Pow((y1-y2),2)), 2)}");
