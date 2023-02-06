// В двумерном массиве заменить элементы, у которых оба индекса чётные на их квадраты
Console.Clear();

Console.WriteLine("Введите размер двумерного массива m x n: ");
Console.Write("количество строк m = ");
int m = int.Parse(Console.ReadLine());
Console.Write("количество столбцов n = ");
int n = int.Parse(Console.ReadLine()); 
int[,] matr = new int[m, n];

FillArray();
Console.WriteLine();
PowEvenArray();   

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

void PowEvenArray()
{            
for (int i = 0; i < matr.GetLength(0); i++)
{
    for (int j = 0; j < matr.GetLength(1); j++)
    {
        if(i % 2 == 0 && j % 2 == 0)
        {
        matr[i,j] = matr[i,j] * matr[i,j];
        }
        Console.Write("{0, 5}", (matr[i, j]).ToString("0"));
        //Console.Write($" {matr[i, j]} ");
    }
Console.WriteLine();
}
}

