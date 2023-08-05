Console.Write("Размер m массива: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Размер n массива: ");
int n = Convert.ToInt32(Console.ReadLine());
double[,] randomArray = new double[m,n];
Console.Write("Позицию строки: ");
int m2 = Convert.ToInt32(Console.ReadLine());
Console.Write("Позицию столбца: ");
int n2 = Convert.ToInt32(Console.ReadLine());

void mas(int m, int n)
{
int i,j;
Random rand = new Random();
for (i = 0; i < m; i++)
{
Console.WriteLine();
for (j = 0; j < n; j++)
{
randomArray[i,j] = rand.NextDouble();
Console.Write($"{randomArray[i,j]:F2} ");
}
Console.WriteLine();
}
}
mas(m,n);
if (m2<1 || n2<1)
Console.Write("Не могут быть отрицательными");
else if (m2 <= m+1 && n2 <= n+1)
Console.Write($"Значение элемента равно {randomArray[m2-1,n2-1]:F2} ");
else Console.Write("Элемента нет в массиве");