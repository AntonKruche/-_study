/* 
Я тут подумал, что проверку на равенство не надо, вроде в любом случае будет и минимальное и максимальное
*/
Console.WriteLine("Введите 2 числа:");
int number1 = int.Parse(Console.ReadLine());
int number2 = int.Parse(Console.ReadLine());
if(number1 >= number2){
    Console.WriteLine($"Наибольшее число {number1}, а наименьшее {number2}");
}
else{
    Console.WriteLine($"Наибольшее число {number2}, а наименьшее {number1}");
}
