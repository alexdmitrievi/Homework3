//В одномерном массиве из 123 чисел найти количество элементов из отрезка [10,99]

Console.Clear();
int[] n = new int[123];
Random rnd = new Random();
int k = 0;
for (int i = 0;i < 123;i++)
{
    n[i] = rnd.Next(-125,125);
    Console.Write($"{n[i]} ");
    if ((n[i] >= 10) & (n[i] <= 99)){
        k = k + 1;
    }
}
Console.WriteLine();
Console.WriteLine($"{k}");