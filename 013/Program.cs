//Удалить вторую цифру целого числа введенного с клавиатуры.

Console.Write("Введите число:");

int a = Convert.ToInt32(Console.ReadLine());

int last = a % 10;

int a0 = a / 100;

a = a0 *10 + last;

Console.WriteLine(a);