int[,] InitArray(int countOfLines = 4, int countOfColumns = 4, int minValue = 0, int maxValue = 10)
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

void GetNumber(int index1, int index2, int[,] array)
{
    if(index1 >= array.GetLength(0) || index2 >= array.GetLength(1))
    {
        Console.WriteLine("такого числа нет в массиве");
    }  
    else Console.WriteLine(array[index1, index2]);

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

int[,] array = InitArray();

PrintArray(array);

Console.WriteLine("Введите первый индекс: ");
int firstIndex = int.Parse(Console.ReadLine());
Console.WriteLine("Введите второй индекс: ");
int secondIndex = int.Parse(Console.ReadLine());

GetNumber(firstIndex, secondIndex, array);

