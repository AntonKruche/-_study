int[] FellArrayRandom(int[] array)
{
    Random randomInt = new Random();

    for(int i = 0; i < array.Length; i++)
    {
        array[i] = randomInt.Next(0, 124);
    }
    return array;
}

int CountOfRange(int[] array)
{
    int count = 0;
    foreach(int el in array)
    {
        count += el > 9 && el < 100 ? 1 : 0;
    }
    return count;
}

int [] array = new int[123];
Console.WriteLine("[{0}]", String.Join(", ", FellArrayRandom(array)));
Console.WriteLine(CountOfRange(FellArrayRandom(array)));
