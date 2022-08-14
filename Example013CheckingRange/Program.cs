Console.Write("Введите четверть : ");
int quarter = int.Parse(Console.ReadLine());
switch(quarter){
    case 1:
        Console.Write($"В четверти {quarter} возможны значения X > 0 и Y > 0");
        break;
    case 2:
        Console.Write($"В четверти {quarter} возможны значения Х < 0 и Y > 0");
        break;
    case 3:
        Console.Write($"В четверти {quarter} возможны значения X < 0 и Y < 0");
        break;
    case 4:
        Console.Write($"В четверти {quarter} возможны значения X < 0 и Y > 0");
        break;
    default:
        Console.Write("Введённое число выходит за рамки [1;4]");
        break;    
}
