// Определить являются ли введенные с клавиатуры символы правильно записью целого числа.
//Вычислить сумму цифр введенного числа

string number;
Input(out number);
int sum = 0;
Init();
Print();



















string Input(out string N)
{
Console.WriteLine("Введите число:");
N = Console.ReadLine();
return N;
}

void Init ()
{
    for (int i = 0; i < number.Length; i++)
    {
        //Показывает, относится ли указанный символ Юникода к категории десятичных цифр.
        if (char.IsDigit(number[i]))
        {
            //преобразует символы ASCII в их числовые значения.
            sum += number[i] - 48;
        }
        else {
            // пропуск минуса в начале, если он есть
            if (i == 0 && number[i] == '-')
            {
                continue;
            }
            else
            {
                Console.WriteLine("Это не является целым числом");
                return;
            }
        }
    }
}

void Print()
{
Console.WriteLine($"Сумма цифр целого числа: {sum}");
}