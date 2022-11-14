Console.WriteLine("How many elements do you want to enter:");
int limit = int.Parse(Console.ReadLine());
var array = new float[limit*2];
Console.WriteLine("Enter flight fare");
for (int i = 0;i<limit*2;i++)
{
    if (i % 2 == 0)
        array[i] = float.Parse(Console.ReadLine());
}
Console.WriteLine("Elements in even position are:");
for (int i = 0; i < limit * 2; i++)
{
    Console.WriteLine(array[i]);
}
