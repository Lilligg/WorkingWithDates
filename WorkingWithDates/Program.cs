
//
//Вывод даты рождения со всеми масками
//

Console.WriteLine("Задание 1 \nВывод моей даты рождения со всеми масками:");

DateTime birthday = new DateTime(2001, 11, 03);

Console.WriteLine($"{birthday:D}");
Console.WriteLine($"{birthday:d}");
Console.WriteLine($"{birthday:F}");
Console.WriteLine($"{birthday:f}");
Console.WriteLine($"{birthday:G}");
Console.WriteLine($"{birthday:g}");
Console.WriteLine($"{birthday:M}");
Console.WriteLine($"{birthday:O}");
Console.WriteLine($"{birthday:o}");
Console.WriteLine($"{birthday:R}");
Console.WriteLine($"{birthday:s}");
Console.WriteLine($"{birthday:T}");
Console.WriteLine($"{birthday:t}");
Console.WriteLine($"{birthday:U}");
Console.WriteLine($"{birthday:u}");
Console.WriteLine($"{birthday:Y}\n\n");

//
//Посчитать сколько дней прошло между 01.01.2000 и 01.01.2023
//


DateTime date1 = new DateTime(2000, 01, 01);
DateTime date2 = new DateTime(2023, 01, 01);

Console.WriteLine($"Задание 2 \nМежду 01.01.2000 и 01.01.2023 прошло: {date2.Subtract(date1)} дней\n\n");

//
//Калькулятор дат
//
Console.WriteLine("Задание 3 \nКАЛЬКУЛЯТОР ДАТ");
Console.WriteLine("Введите дату в формате: дд.мм.гггг");


var date = DateTime.ParseExact(Console.ReadLine(), "dd.MM.yyyy", null);

Console.WriteLine("Введите количество дней, которые нужно прибавить или убрать:\n(например, -3, если вычесть; 3, если прибавить)");
int day = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Получилась дата: " + date.AddDays(day));