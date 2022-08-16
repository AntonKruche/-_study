Console.Write("Введите число: ");
int num = int.Parse(Console.ReadLine());
Console.Write(SummOf(num));
int SummOf(int a){
    int summ = 0;
    for(int index = 0; index <= a; index++){
        summ += index;
    }
    return summ;
}

