Console.WriteLine("Введите число");
int number = Math.Abs(int.Parse(Console.ReadLine())) / 100;
switch(number)
{
    case 0:
        Console.Write("Третьей цифры нет");
        break; 

    case > 10:
        Console.WriteLine(number % 10);
        break;
    default :
        Console.WriteLine(number);
        break;
}     
