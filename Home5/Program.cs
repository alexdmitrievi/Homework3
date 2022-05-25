//Найти произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д.

Console.Clear();
Console.WriteLine("ведите колличество элементов в массиве");
int k = Convert.ToInt32(Console.ReadLine()); 
int[] n = new int[k];
Random rnd = new Random();
int p = 0;
for (int i = 0; i < k; i++){
    n[i] = rnd.Next(0,100);
    Console.Write($"{n[i]} ");
}
for (int i = 0; i < k/2; i++){
    p = n [i] * n [k-(i+1)];
    Console.WriteLine();
    Console.WriteLine($"{p}");
}


