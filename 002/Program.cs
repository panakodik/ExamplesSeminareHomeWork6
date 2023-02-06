// Задать двумерный массив следующим правилом: Aₘₙ = m+n
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
            
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        matr[i, j] = i + j;
        Console.Write("{0, 5}", (matr[i, j]).ToString("0"));
        //Console.Write($" {matr[i, j]} ");
    }
Console.WriteLine();
}
}
    

