// Напишите программу, которая на вход принимает координаты точки (X и Y), причем X Y не равны нулю, и выдает номер четверти плоскости, в которой эта точка находится  2 | 1
//                                                 3 | 4
Console.Write("Введите x: ");
int x = int.Parse(Console.ReadLine());
Console.Write("Введите y: ");
int y = int.Parse(Console.ReadLine());
if (x>0 && y>0)
{
    Console.Write("1 четверть");
}
if (x<0 && y>0)
{
    Console.Write("2 четверть");
}
if (x<0 && y<3)
{
    Console.Write("3 четверть");
}
if (x>0 && y<0)
{
    Console.Write("4 четверть");
}