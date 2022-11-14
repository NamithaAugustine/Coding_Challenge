using System.Collections.Immutable;
using System.Globalization;

var names = new string[5];
string temp;
Console.WriteLine("Enter 5 names: ");
for(int i=0; i<names.Length; i++)
{
    names[i] = Console.ReadLine();
}
for (int i=0; i<=names.Length; i++)
{
    for (int j = i+1; j <names.Length; j++)
    {
        if (names[i][0] > names[j][0])
        {
            temp= names[j];
            names[j] = names[i];
            names[i] = temp;
        }
    }
}
Console.WriteLine();
Console.WriteLine("Assending:");
for (int i = 0; i < names.Length; i++)
{
    Console.WriteLine(names[i]);
}
Console.WriteLine();
Console.WriteLine("Dessending:");
for (int i = names.Length-1; i >=0; i--)
{
    Console.WriteLine(names[i]);
}

Console.WriteLine();
Console.WriteLine("Length is:");
for (int i = 0; i < names.Length; i++)
{
    int count =0;
    foreach (var item in names[i])
    {
        
        if (item == ' ')
            continue;
        count++;
    }
    Console.WriteLine($"Length of {names[i]} is {count}");
}
Console.WriteLine();
Console.WriteLine("Split");
bool flag = false;
string[] splits = new string[6];
foreach (string PassengerName in names)
{
    splits = PassengerName.Split(" ");
}
Console.WriteLine($"Split Elements are {string.Join(" ",splits)}");
Console.WriteLine();
Console.WriteLine("Search:");
string s;
Console.Write("Element for search:");
s = Console.ReadLine();
int scount = 0;
int k = 0;
foreach (string Name in splits)
{
    if (s.ToLower() == Name.ToLower())
    {
        scount++;
        Console.WriteLine($"Passenger name {s} is found ");
    }
    k++;
    
}
if (scount == 0)
{
    Console.WriteLine("No such passenger found");
}


Console.WriteLine();
Console.WriteLine("Duplicates");
var duplicates = new string[names.Length];
int k1 = 0;
foreach (var item in names)
{  
    int count1 = 0;  
    foreach (var name in names) 
    {
        if(item == name){
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
                duplicates[k1++] = item;
        }
    }

}
Console.Write("Duplicates are: ");
Console.WriteLine(String.Join("  ", duplicates));





