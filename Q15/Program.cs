using Q15;

Console.WriteLine("Enter your laguage weight and payment");

Weight[] w= new Weight[5];
Weight temp = new Weight();

for (int i=0;i<5; i++)
{
    w[i]= new Weight();
    Console.WriteLine();
    Console.Write("Weight: ");
    w[i].ExtraWeight= int.Parse(Console.ReadLine());
    Console.Write("Payment: ");
    w[i].Payment = int.Parse(Console.ReadLine());
    Console.WriteLine();
    Console.WriteLine($"The new payment is:{w[i].Payment}");
}
for(int i=0;i<4;i++)
{
    for(int j=0;j<4-i;j++)
    {
        if (w[j].ExtraWeight > w[j+1].ExtraWeight)
        {
            temp = w[j];
            w[j] = w[j +1];
            w[j +1] = temp;

        }
    }
}
Console.WriteLine();
Console.Write("The sorted payment is:");
for(int i= 0;i<5;i++)
{
    Console.Write(w[i].Payment+" ");
}
