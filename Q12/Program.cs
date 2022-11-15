
Console.Write("How many entries you want? ");
int limit = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("Enter Passenger Name and Destination: ");

var name = new string[limit];
var destination = new string[limit];
var details = new string[limit*2];

for(int i = 0;i<name.Length;i++)
{
    Console.WriteLine();
    Console.Write("Name: ");
    name[i] = Console.ReadLine();
    Console.Write("Destination: ");
    destination[i] = Console.ReadLine();
}
int j = 0;
for (int i = 0; i<limit*2;i+=2)
{
    
    
        details[i] = name[j];
    
        details[i+1] = destination[j];
    j++;
      
}
Console.WriteLine();
Console.WriteLine("Details are:");
Console.WriteLine();
for(int i=0; i<limit*2;i++)
{
    Console.WriteLine(details[i]);
}
