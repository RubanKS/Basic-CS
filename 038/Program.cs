//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

int count = 0;

int[] a = new int[123];
Random random = new Random();

for (int i = 10; i < 99; i++)
    count = count + 1;

System.Console.WriteLine($"В отрезке всего элементов: {count}");