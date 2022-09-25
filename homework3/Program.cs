//Задача 23: Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

Console.Write("Введите число: ");
int number = int.Parse(Console.ReadLine());
int count = 1; // ввести счетчик

Console.Write($"{number} -> ");
while (count < number)
{
    Console.Write($"{Math.Pow((count), 3)}, ");
    count++;
}
if (count == number) // чтобы не было в конце запятой
{
    Console.Write($"{Math.Pow((count), 3)}");
}