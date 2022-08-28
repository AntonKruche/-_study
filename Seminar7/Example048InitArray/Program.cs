int[,] InitArray(int countOfLines, int countOfColumns)
{
    int[,] resultArray = new int[countOfLines, countOfColumns];
    
    for(int i = 0; i < countOfLines; i++)
    {
        for(int j = 0; j < countOfColumns; j++)
        {
            resultArray[i, j] = i + j;
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