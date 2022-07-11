//По двум заданным числам проверять является ли первое квадратом второго

double a,b;
string? s=Console.ReadLine();
a=Convert.ToDouble(s);
s=Console.ReadLine();
b=Convert.ToDouble(s);
if (a*a==b)
{
    System.Console.WriteLine("b is square a");
}
else
{
    System.Console.WriteLine("b is't square a");
}
if (a==b*b)
{
    System.Console.WriteLine("a is squre b");
}
else
{
    System.Console.WriteLine("a is't square b");
}