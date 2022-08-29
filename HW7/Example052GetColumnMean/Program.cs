﻿int[,] InitArray(int countOfLines = 4, int countOfColumns = 4, int minValue = 0, int maxValue = 10)
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

void GetColumnMean(int[,] array)
{   
    double count;
    double mean;
    for(int i = 0; i < array.GetLength(1); i++)
    {   
        count = 0;
        mean = 0;

        for(int j = 0; j < array.GetLength(0); j++)
        {
            count += array[j, i];
        }
        mean = Math.Round(count / 2, 2);
        Console.Write($"{mean}; ");
    }
}

int[,] array = InitArray();

GetColumnMean(array);