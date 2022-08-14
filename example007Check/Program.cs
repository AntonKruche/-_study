Console.WriteLine("Введите 2 числа");
int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
switch (num1 % num2)
{
    case 0:
        Console.WriteLine("Число 2 кратно числу 1");
        break;
    default:
        Console.WriteLine($"Число 2 не кратно числу 1, остаток от делания равен {num1 % num2}");
        break;
}