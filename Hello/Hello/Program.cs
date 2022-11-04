

Console.Write("Введите свое имя: ");
string? name = Console.ReadLine();

Console.WriteLine($"Давайте я посчитаю за вас {name},введите число ниже:");

String? a = Console.ReadLine();
int numA;
bool succes = int.TryParse(a,out numA);

if (succes)
{
    Console.WriteLine($"Отличные новости идем дальше.Введите второе число ниже:");
     String? b = Console.ReadLine();
      int numB;
       bool finSucces = int.TryParse(b, out numB);
      if (finSucces)
      {
        Console.WriteLine($"Вы молодец, ваш ответ {numA+numB}");
      }
      else
      {
        Console.WriteLine($"Вы пытались меня обмануть.Поделом вам!");
    }
    
}
else
{
    Console.WriteLine($"Ну вот ты все испортил");
}













