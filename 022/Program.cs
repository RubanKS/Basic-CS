// Программа проверяет пятизначное число на палиндромом

Console.Write("Введите число:");
string s = (Console.ReadLine());

if (s.Reverse().SequenceEqual(s)) Console.WriteLine("Палиндром");
else Console.WriteLine("Не Палиндром");
