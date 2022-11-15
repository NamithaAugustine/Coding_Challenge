int limit;


Console.Write("How many passenger details you want to enter: ");
limit = int.Parse(Console.ReadLine());

var fare = new float[limit];
var destination = new string[limit];

Console.WriteLine();
Console.WriteLine("Enter Fare and Destination:");
Console.WriteLine();
for(int i = 0;i < limit; i++)
{
    Console.Write("Fare: ");
    fare[i] = float.Parse(Console.ReadLine());
    Console.Write("Destination: ");
    destination[i] = Console.ReadLine();
    Console.WriteLine();
}
Console.Write("Enter index for search:");
int index = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine($"Fare is {fare[index - 1]}, Destination is {destination[index - 1]} for index {index}");
