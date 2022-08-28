int[,] InitArray(int countOfLines, int countOfColumns, int minValue = 0, int maxValue = 10)
{
    int[,] resultArray = new int[countOfLines, countOfColumns];
    Random random = new Random();
    for(int i = 0; i < countOfLines; i++)
    {
        for(int j = 0; j < countOfColumns; j++)
        {
            resultArray[i, j] = random.Next(minValue, maxValue + 1);
        }
    }
    return resultArray; 
}

void PrintArray(int[,] array)
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

int[,] array = InitArray(lineQuantity, columnQuantity);

PrintArray(array);