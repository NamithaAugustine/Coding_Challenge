using Q2;

var p1 = new Fare();

Console.WriteLine("Enter Time");
p1.Time = int.Parse(Console.ReadLine());
p1.Am_Pm = Console.ReadLine();
Console.WriteLine("Enter Fare");
p1.Pfare = int.Parse(Console.ReadLine());

Console.WriteLine(p1.Pfare);