Console.Write("Enter username: ");

string userName = Console.ReadLine();

if (userName.ToLower() == "john")
{
	Console.WriteLine("Hey, it is John! Finally!");
}
else
{
	Console.WriteLine("Well, hi, " + userName);
}

