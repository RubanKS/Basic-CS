/* Много строчный комментарий
int a=2, b=3;//Операция присваивания
//int s=a+b;

//Console.WriteLine(a+"+"+b+"="+s); // склеивание строк
//Console.WriteLine("{0}+{1}={2}",a,b,s); //строка форматирования
//Console.WriteLine($"{a}+{b}={s}"); // строка интерполяции

Console.Write("Введите число: ");
int a = Console.ReadLine();
int q = a + a;
Console.WriteLine($"{a}^{2}={q}");

*/

//Вывести квадрат числа
double a;
double q;
string? s;
Console.Write("Введите число: ");
s = Console.ReadLine();
a = Convert.ToDouble(s);
//a = Convert.ToDouble(s)
q = a * a;
Console.WriteLine($"{a}^2={q}");