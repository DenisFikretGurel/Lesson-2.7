// See https://aka.ms/new-console-template for more information
//Задание 1
string FullName = "Alerksey";
int Age = 35;
string Email = "aleksey@yandex.ru";
double ITpoints = 32.5;
double Mthpoints = 42.5;
double Phpoints = 52.56;
Console.WriteLine("Полное имя - {0} \nВозраст - {1} \nEmail - {2} \nИнформатика - {3} \nМатематика - {4} \nФизика - {5}",
    FullName,
    Age,
    Email,
    ITpoints,
    Mthpoints,
    Phpoints);
Console.ReadKey();
//Задание 2
double TotalSum = ITpoints + Mthpoints + Phpoints;
Console.WriteLine("Общая сумма балов =" +TotalSum);
double Average = (ITpoints + Mthpoints + Phpoints)/3;
Console.WriteLine("Среднее число балов =" + Average);