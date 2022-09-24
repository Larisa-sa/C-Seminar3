// Задача 19: Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 14212 -> нет
// 23432 -> да
// 12821 -> да

Console.Write("Введите пятизначное число: ");
string? number = Console.ReadLine(); // строка
void checking(string number){ // проверка

  if (number[0]==number[4] && number[1]==number[3]){
    Console.WriteLine($"{number} -> да");
  }
  else Console.WriteLine($"{number} -> нет");
}

if (number!.Length == 5){
  checking(number);
}
else 
Console.WriteLine($"Ошибка. Введено не пятизначное число");