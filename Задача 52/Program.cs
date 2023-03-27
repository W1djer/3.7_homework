void InputMatrix(int[,] matrix)
{
    for (int i = 0; i < matrix.GetLength(0); i++)
    {
        for (int j = 0; j < matrix.GetLength(1); j++)
        {
            matrix[i, j] = new Random().Next(0, 11);
            Console.Write($"{matrix[i, j]} \t");
        }
        Console.WriteLine();
    }
}
void Release(int[,] matrix)
{
   double sum = 0;
   for (int j = 0; j < matrix.GetLength(1); j++)
    {
        for (int i = 0; i < matrix.GetLength(0); i++)
        {
            sum += matrix[i,j];
        }
        Console.WriteLine($"Среднее арифметическое столбца {j+1} = {sum/4}");
        sum = 0;
    }
}
int[,] matrix = new int[4, 5];
InputMatrix(matrix);
Release(matrix);