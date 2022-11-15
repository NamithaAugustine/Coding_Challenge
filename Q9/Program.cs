var dob = new DateTime[4];
Console.WriteLine("Enter Date of Birth of 10 passengers: ");
for(int i = 0;i<dob.Length;i++)
{
    dob[i] = DateTime.Parse(Console.ReadLine());
}
string category;
int age;
for (int i = 0; i < dob.Length; i++)
{
    age = (int)((DateTime.Now - dob[i]).TotalDays / 365.242199);
    if (age < 10)
        category = "Kid";
    else if (age >= 10 && age < 30)
        category = "Youth";
    else if (age >= 30 && age < 60)
        category = "Adult";
    else
        category = "Older";
    Console.WriteLine($"{i+1} {dob[i].Date} is a " + category);
}