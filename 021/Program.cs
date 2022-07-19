// Задать номер четверти, показать диапазоны для возможных координат

Console.Write("Введите номер четверти:");
int n = Convert.ToInt32(Console.ReadLine());

if (n == 1) System.Console.WriteLine("Возможные координаты лежат x>0 и y>0");
if (n == 2) System.Console.WriteLine("Возможные координаты лежат x<0 и y>0");
if (n == 3) System.Console.WriteLine("Возможные координаты лежат x<0 и y<0");
if (n == 4) System.Console.WriteLine("Возможные координаты лежат x>0 и y<0");


/*
int AreaN(double n)
{
    System.Console.WriteLine($"x={x} y={y}");
    if (x>0 && y>0) return 1;
    if (x<0 && y>0) return 2;
    if (x>0 && y>0) return 3;
    if (x>0 && y>0) return 4;
    return 0;
}
*/

/*
int Quarter (int n)
{
    if (n == 1) return Convert.ToString("x>0 && y>0");
    if (n == 2) return Convert.ToString("x<0 && y>0");
    if (n == 3) return Convert.ToString("x<0 && y<0");
    if (n == 4) return Convert.ToString("x>0 && y<0");
    return 0;
}
*/

