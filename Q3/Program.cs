var fare = new float[10];
Console.WriteLine("Enter 10 fares:");
for (int i = 0;i<fare.Length;i++)
{
    fare[i]=float.Parse(Console.ReadLine());
}
Console.WriteLine();
Console.WriteLine("Search");
Console.WriteLine("Enter number for search");
float search = int.Parse(Console.ReadLine());
int count = 0;
for(int i = 0;i< fare.Length;i++)
{
    if (fare[i]==search)
    {
        count++;
        Console.WriteLine($"The element found in position {i + 1}");
    }
}
if(count==0)
    Console.WriteLine("Element not found");
Console.WriteLine();
Console.WriteLine("Assending");
float temp;
for (int i = 0; i < fare.Length; i++)
{
    for (int j = i+1; j < fare.Length; j++)
    {
        if (fare[i] > fare[j])
        {
            temp = fare[j];
            fare[j] = fare[i];
            fare[i] = temp;

        }
    }
}
foreach (var item in fare)
{
    Console.WriteLine(item);
}
Console.WriteLine();
Console.WriteLine("Decending");
for (int i = 0;i< fare.Length;i++)
{
    for(int j=i;j<fare.Length;j++)
    {
        if (fare[j] > fare[i])
        {
            temp = fare[j];
            fare[j] = fare[i];
            fare[i] = temp;

        }
    }
}
foreach (var item in fare)
{
    Console.WriteLine(item);
}
Console.WriteLine() ;
Console.WriteLine($"The max number is: {fare[0]}");
Console.WriteLine();
Console.WriteLine($"The min number is: {fare[fare.Length-1]}");
Console.WriteLine();
Console.WriteLine("Duplicates");
var duplicates = new float[fare.Length];
int k = 0;
foreach (var item in fare)
{
    int count1 = 0;
    foreach (var name in fare)
    {
        if (item == name)
        {
            count1++;
        }
        if (count1 >= 2)
        {
            bool hasFoundMatch = false;
            foreach (var str in duplicates)
            {
                if (str == item)
                {
                    hasFoundMatch = true;
                    break;
                }
            }
            if (!hasFoundMatch)
                duplicates[k++] = item;
        }
    }



}
Console.WriteLine(String.Join("  ", duplicates));

