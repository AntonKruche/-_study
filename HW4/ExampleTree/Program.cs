string SpaceExist(int count)
{
    string result = String.Empty;
    for(int i = 0; i < count; i++){
        result +=" ";
    }
    return result;
}

void TreeExist(int height)
{
    int countOfSpace = 0;
    int bodyCount;
    string space;
    string body = "*";
    for(int i = 1; i < height + 1; i++)
    {
        countOfSpace = height - i;
        space = SpaceExist(countOfSpace);
        Console.WriteLine("{0}{1}", space, body);
        body += "**";
    }
}

Console.Write("Введите высоту ёлочки: ");
int height = int.Parse(Console.ReadLine());
TreeExist(height);
