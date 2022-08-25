int[] GetArray(int size, int start, int end)
{
    int[] ResultArray = new int[size];
    Random random = new Random();
    for(int i = 0; i < ResultArray.Length; i++)
    {
        ResultArray[i] = random.Next(100, 1000);
    }
    return ResultArray;
}

int GetCountOfEven(int[] array)
{
    int result = 0;
    foreach(int el in array)
    {
        result += el % 2 == 0 ? 1 : 0;
    }
    return result;
}
Console.WriteLine("Введите размер массива: ");
int size = int.Parse(Console.ReadLine());
int start = 100;
int end = 1000;

int[] array = GetArray(size, start, end);
Console.WriteLine(GetCountOfEven(array));

