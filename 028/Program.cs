//Определить количество цифр в числе. Сделать подпрограмму.

System.Console.WriteLine();

int CountDigits(int N)
{
    if (N==0) return 1;
    int k=0;
    while(N!=0)
    {
        k++;
        N/=10;
    }
    return k;
}

int N=1234;
int k=0;
while (N!=0)
{

    k++;
    //N=N/10;
    N/=10;
}

System.Console.WriteLine(k);

/* Решение на выходе
//28. Определить количество цифр в числе. Сделать подпрограмму.
System.Console.WriteLine(CountDigits(0));

int CountDigits(int N)
{
    if (N==0) return 1;
    int k=0;
    while(N!=0)
    {
        k++;
        N/=10;        
    }
    return k;
}
*/