// Напишите программу, которая принимает на вход число (N) и выдает таблицу квадратов чисел от 1 до N
// 5 -> 1, 4, 9, 16, 25
// 2 -> 1, 4
Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = 0; // ввести счетчик

Console.Write($"{number} -> ");
while (count < number)
{
    Console.Write($"{Math.Pow((count), 2)}, ");
    count++;
}
if (count == number) // чтобы не было в конце запятой
{
    Console.Write($"{Math.Pow((count), 2)}");
}