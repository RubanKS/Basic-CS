//С клавиатуры вводится целое число. Вывести третью цифру числа или сообщить, что её нет.

Console.Write("Введите целое число:");
int a = Convert.ToInt32(Console.ReadLine());
//if (a >= 100 || a<=-100) // || - или
if (Math.Abs(a)>=100) //абсолютное значение (по модулю)
{
    System.Console.WriteLine(a / 10 / 10 % 10);
}
else
{
    System.Console.WriteLine("Число имеет меньше трёх цифр");
}