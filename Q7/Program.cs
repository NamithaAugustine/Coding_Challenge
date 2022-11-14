using Q7;

Console.WriteLine("Enter Name and Miles travelled");
var p = new flyerpoints();
Console.Write("Name: ");
p.Name = Console.ReadLine();
Console.Write("Miles: ");
p.Miles = int.Parse(Console.ReadLine());
p.FrequentFlyerPoints = 10;
Console.WriteLine($"The frequent flyer point is: {p.FrequentFlyerPoints}");
Console.WriteLine(p.FrequentFlyerPoints);
