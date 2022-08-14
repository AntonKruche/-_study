Console.Write("Введите Х: ");
int Xcoord = int.Parse(Console.ReadLine());
Console.Write("Введите Y: ");
int Ycoord = int.Parse(Console.ReadLine());
switch(Xcoord){
    case > 0 :
        if(Ycoord > 0){
            Console.Write("1");
        }
        else{
            Console.Write("4");
        }
        break;    
    case < 0 :
        if(Ycoord > 0){
            Console.Write("2");
        }
        else{
            Console.Write("3");
        }
        break;
    default :
        Console.Write("Кто-то равен нулю");
        break;
}