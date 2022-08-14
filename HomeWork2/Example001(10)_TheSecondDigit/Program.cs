Console.WriteLine("Введите трёхзначное число");
int number = int.Parse(Console.ReadLine());
number = number / 10;
number = number % 10;
Console.Write(number);