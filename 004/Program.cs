// Написать программу, которая обменивает элементы первой строки и последней строки

Console.Clear();

Console.WriteLine("Введите размер двумерного массива m x n: ");
Console.Write("количество строк m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("количество столбцов n = ");
int n = int.Parse(Console.ReadLine()); 
int[,] matr = new int[m, n];

FillArray();
Console.WriteLine();
SwapArray();

void FillArray()
{            
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i,j] = new Random().Next(1,10); // [1; 10)
        Console.Write("{0, 5}", (matr[i, j]).ToString("0"));
        //Console.Write($" {matr[i, j]} ");
    }
Console.WriteLine();
}
}

void SwapArray()
{            
   int temp = 0;
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        temp = matr[0, j];
        matr[0, j] = matr[n - 1, j];
        matr[n - 1, j] = temp;
        Console.Write("{0, 5}", (matr[i, j]).ToString("0"));
        //Console.Write($" {matr[i, j]} ");
    }
Console.WriteLine();
}
}
