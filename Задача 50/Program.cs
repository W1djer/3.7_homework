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
    Console.Write("Введите позицию элемента: ");
    int[] element = Console.ReadLine().Split(" ").Select(x => int.Parse(x)).ToArray();
    if (element[0] < 5 && element[1] < 5)
        Console.WriteLine($"{matrix[element[0], element[1]]}");
    else
        Console.WriteLine("Такого элемента нет");
}
int[,] matrix = new int[5, 5];
InputMatrix(matrix);
Release(matrix);