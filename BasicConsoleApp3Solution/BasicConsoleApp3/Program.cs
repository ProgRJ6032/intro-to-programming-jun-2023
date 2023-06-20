using Display;

using GeneralUtilities;

Greetings.DisplayWelcome();
Console.Write("Can you enter your first name? ");
string firstName = Console.ReadLine();
Console.Write("Can you enter your last name? ");
string lastName = Console.ReadLine();


string fullName = Formatters.FormatName(firstName, lastName);
Console.WriteLine($"Hello, {fullName}");