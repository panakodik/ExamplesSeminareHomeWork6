//Показать двумерный массив размером m×n заполненный вещественными числами
Console.Clear();

FillArray();       
void FillArray()
{
Console.WriteLine("Введите размер двумерного массива m x n: ");
Console.Write("количество строк m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("количество столбцов n = ");
int n = int.Parse(Console.ReadLine()); 

double[,] matr = new double[m, n];
Random random = new Random();
            
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = Math.Round((random.NextDouble() * 200 - 100), 2);
        //matr[i, j] = Math.Round(random.Next(100) + random.NextDouble(), 3);
        Console.Write("{0, 10}", (matr[i, j]).ToString("0.00"));
        //Console.Write($" {matr[i, j]} ");
    }
Console.WriteLine();
}
}
    

