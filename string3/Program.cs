// С клавиатуры вводится строка разделенная точкой.
//Подсчитать количество символов до точки

string text;
Input (out text);
int before = text.IndexOf('.');
Print(before);









string Input(out string t)
{
Console.WriteLine("Введите текст:");
t = Console.ReadLine();
return t;
}

void Print(int before)
{
Console.WriteLine($"До точки {before} символов");
}
