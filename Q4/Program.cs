DateTime Dob;
Console.WriteLine("Enter Date of Birth of Passenger: ");
Dob = DateTime.Parse((Console.ReadLine()));

int age = (int)((DateTime.Now - Dob).TotalDays / 365.242199);
Console.WriteLine($"The age in years is {age}");
double days = ((DateTime.Now - Dob).TotalDays);
double months = days / 30.41;
Console.WriteLine($"The age in months is {months}");
Console.WriteLine($"The age in days is {days}");
double hrs = days * 24;
Console.WriteLine($"The age in hours is {hrs}");
double mins = hrs*60;
Console.WriteLine($"The age in minutes is {mins}");
double secs = mins * 60;
Console.WriteLine($"The age in seconds is {secs}");
if(Dob.Year%4==0)
{
    Console.WriteLine("The person was born in Leap year");
}
