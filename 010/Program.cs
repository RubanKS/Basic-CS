// Вывести на экран последнюю цифру целого числа введенного с клавиатуры.

int a;
Console.Write("Введите число:");
a = Convert.ToInt32(Console.ReadLine());

int last = a % 10;

Console.WriteLine(last);