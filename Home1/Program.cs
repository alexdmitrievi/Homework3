int[] n = new int[8];
Random rnd = new Random();
for (int i = 0;i < 8;i++)
{
    n[i] = rnd.Next(0,2);
    Console.Write($"{n[i]} ");
}
