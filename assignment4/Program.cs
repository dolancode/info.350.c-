// See https://aka.ms/new-console-template for more information

Console.WriteLine("What is your favorite day of the week as an integer");
int day = Int32.Parse(Console.ReadLine());

if (day <= 7)
{
    Console.WriteLine("Valid Day Entered");
}
else
{
    throw new Exception("Invalid Day Entered");
}

string dayStr = "";

switch (day)
{
    case 1:
        dayStr = "Monday";
        break;
    case 2:
        dayStr = "Tuesday";
        break;
    case 3:
        dayStr = "Wednesday";
        break;
    case 4:
        dayStr = "Thursday";
        break;
    case 5:
        dayStr = "Friday";
        break;
    case 6:
        dayStr = "Saturday";
        break;
    case 7:
        dayStr = "Sunday";
        break;
}

Console.WriteLine($"It's {dayStr}!");