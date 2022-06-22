Console.WriteLine("Enter number, to choose:");

var days = Enum.GetValues<Days>();
foreach (var day in days)
{
	Console.WriteLine($"{(int)day} - {day}");
}

var number = int.Parse(Console.ReadLine());
Console.WriteLine((Days)number);

enum Days // По умолчанию byte 0-255
{
	Monday = 1, // По умолчанию с 0
	Tuesday,
	Wednesday,
	Thursday,
	Saturday,
	Sunday,
}