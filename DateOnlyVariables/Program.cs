
DateTime today = DateTime.Now;

DateOnly birthday = DateOnly.Parse("6/11/1998");

Console.WriteLine(birthday.ToString("MM/dd/yyyy"));


Console.WriteLine($"Today full format: {today}");
Console.WriteLine($"Today just dat {today.Date}");
Console.WriteLine($"Birthday full format: {birthday}");