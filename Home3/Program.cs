//Задать массив, заполнить случайными положительными трёхзначными числами. Показать количество нечетных\четных чисел

Console.Clear();
int[] n = new int[10];
Random rnd = new Random();
int k1 = 0;
int k2 = 0;
for (int i = 0; i < 10; i++){
    n[i] = rnd.Next(100,1000);
    Console.Write($"{n[i]} ");
    if (n[i] % 2 == 0) {
        k1 = k1 + 1;
    }
    else {
        k2 = k2 + 1;
    }

}
Console.WriteLine();
Console.WriteLine($"четных {k1}, нечетных {k2}");