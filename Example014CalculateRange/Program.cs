Console.Write("Введите координату X первой точки : ");
int Xcoord1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y первой точки : ");
int Ycoord1 = int.Parse(Console.ReadLine());
Console.Write("Введите координату X второй точки : ");
int Xcoord2 = int.Parse(Console.ReadLine());
Console.Write("Введите координату Y второй точки : ");
int Ycoord2 = int.Parse(Console.ReadLine());
double range = Math.Sqrt(Math.Pow(Xcoord1 - Xcoord2, 2) + Math.Pow(Ycoord1 - Ycoord2, 2));
Console.Write($"Расстояние между двумя точками равно {range}");

