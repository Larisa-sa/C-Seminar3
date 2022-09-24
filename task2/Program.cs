// Напишите программу, которая по заданному номеру четверти показывает диапазон возможных координат точек в этой четверти (x и y)
Console.Write("Введите номер четверти: ");
int quarter = int.Parse(Console.ReadLine());
if (quarter == 1 )
{
    Console.WriteLine("х = 1,2,3...n, y = 1,2,3...n ");
}
if (quarter == 2 )
{
    Console.WriteLine("х = -1,-2,-3...n, y = 1,2,3...n ");
}
if (quarter == 3 )
{
    Console.WriteLine("х = -1,-2,-3...n, y = -1,-2,-3...n ");
}
if (quarter == 4 )
{
    Console.WriteLine("х = 1,2,3...n, y = -1,-2,-3...n ");
}