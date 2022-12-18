Console.WriteLine($"Введите размерность m - количество строк ");
int m = Convert.ToInt32(Console.ReadLine());
Console.WriteLine($"Введите размерность n - количество столбцов ");
int n = Convert.ToInt32(Console.ReadLine());
int range = InputNumbers("Введите диапазон: от 1 до ");

int[,] array = new int[m, n];
PrintArray(array);
CreateArray(array);

int minSumLine = 0;
int sumLine = MinElement(array, 0);
for (int i = 1; i < array.GetLength(0); i++)
{
    int tempSumLine = MinElement(array, i);
    if (sumLine > tempSumLine)
    {
        sumLine = tempSumLine;
        minSumLine = i;
    }
}
Console.WriteLine($"{minSumLine + 1} - строкa с наименьшей суммой ({sumLine +1 }) элементов ");

int MinElement(int[,] array, int i)
{
    int sumLine = array[i, 0];
    for (int j = 1; j < array.GetLength(1); j++)
    {
        sumLine += array[i, j];
    }
    return sumLine;
}

int InputNumbers(string input)
{
    Console.Write(input);
    int output = Convert.ToInt32(Console.ReadLine());
    return output;
}

void PrintArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(range);
        }
    }
}

void CreateArray(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write(array[i, j] + " ");
        }
        Console.WriteLine();
    }
}