List<string> wrongPasswords = new List<string>();

Console.WriteLine("Enter Password");

string password = Console.ReadLine();
int i = 1;
do
{
    Console.WriteLine($"Reenter your password. Attempt {i}/5");
    string reenter = Console.ReadLine();

    if (password == reenter)
    {
        Console.WriteLine("Login Succesful");
        break;
    }
    Console.WriteLine("Login Failed");
    wrongPasswords.Add(reenter);
    i++;
}
while (i < 6);


Console.WriteLine("Your failed attempts are:");
for (int j = 0; j < wrongPasswords.Count(); j++)
{
    Console.WriteLine(wrongPasswords.ElementAt(j));
}