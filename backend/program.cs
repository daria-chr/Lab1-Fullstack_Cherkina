// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Привет");
// Console.WriteLine("Черкина Дарья Алексеевна");
// Console.WriteLine(DateTime.Now);

Console.Write("Введите ваше имя ");
string name=Console.ReadLine();
Console.WriteLine($"Привет, {name}");
Console.WriteLine($"Сегодня {DateTime.Now.DayOfWeek}");
Console.Write("Хотите продолжить? y/n ");
string answer=Console.ReadLine();
if (answer.ToLower()=="y"){
    Console.WriteLine("Продолжаем!");
} else
{
    Console.WriteLine("Конец");
}