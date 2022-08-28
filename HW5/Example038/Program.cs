double[] GetArray(int size)
{
    double[] ResultArray = new double[size];
    Random random = new Random();
    for(int i = 0; i < ResultArray.Length; i++)
    {
        ResultArray[i] = random.NextDouble();
    }
    return ResultArray;
}

double GetDiffMinMax(double[] array)
{
    double min = array[0];
    double max = array[0];
    for(int i = 1; i < array.Length; i++)
    {
        min = array[i] < min ? array[i] : min;
        max = array[i] > max ? array[i] : max;
    }
    return max - min;
}

/*Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());

double[] array = GetArray(size);*/
double[] array = new double[5];
for(int i = 0; i < 5; i++)
{
    Console.WriteLine("Введите число: ");
    array[i] = double.Parse(Console.ReadLine());
}
Console.WriteLine(GetDiffMinMax(array));