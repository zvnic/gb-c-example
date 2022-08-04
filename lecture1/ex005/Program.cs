// See https://aka.ms/new-console-template for more information
Console.WriteLine("Enter your Name:");
string userName = Console.ReadLine();

if (userName.ToLower() == "маша") {
    Console.WriteLine("Ура привет, Маша!");
} else {
    Console.WriteLine("Привет, " + userName);
}
