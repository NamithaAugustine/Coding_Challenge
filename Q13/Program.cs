int[] flightNumbers = { };
bool t = true;
string flightFare;
int ff;
int i =0;
while (t)
{
    Console.Write("Enter Flight number or enter q to exit:");
    flightFare = Console.ReadLine();
    if (flightFare == "q")
    {
        t = false;
        break;
        
    }
    else
    {
        ff = int.Parse(flightFare);
        var temp = new int[flightNumbers.Length+1];
        for (i = 0; i < flightNumbers.Length; i++)
        {
            temp[i] = flightNumbers[i];
        }
        temp[flightNumbers.Length] = ff;
        flightNumbers= temp;
    }
}
Console.WriteLine();
Console.WriteLine("The Flight numbers are:");
Console.WriteLine();
for(i=0;i<flightNumbers.Length;i++)
{
    Console.WriteLine(flightNumbers[i]);
}