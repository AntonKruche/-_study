double[,] InitArray(int countOfLines, int countOfColumns, int min = -100, int max = 100)
{
    double[,] resultArray = new double[countOfLines, countOfColumns];
    Random random = new Random();
    for(int i = 0; i < countOfLines; i++)
    {
        for(int j = 0; j < countOfColumns; j++)
        {
            resultArray[i, j] = Math.Round(random.NextDouble(), 4) * (max - min) + min;

        }
    }
    return resultArray; 
}

void PrintArray(double[,] array)
{
    for(int i = 0; i < array.GetLength(0); i++)
    {
        for(int j = 0; j < array.GetLength(1); j++)
        {
            Console.Write($"{array[i,j]} ");
        }
        Console.WriteLine();
    }
}

Console.WriteLine("Введите количество строк: ");
int lineQuantity = int.Parse(Console.ReadLine());
Console.WriteLine("Введиет количество столбиков: ");
int columnQuantity = int.Parse(Console.ReadLine());

double[,] array = InitArray(lineQuantity, columnQuantity);

PrintArray(array);

