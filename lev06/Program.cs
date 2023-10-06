// See https://aka.ms/new-console-template for more information
/* Szekvenciális program - input - output
string message = "Ez az első programom!\n";
int x = (Console.WindowWidth - message.Length) / 2;
Console.SetCursorPosition(x, 5);
Console.Write(message); //write a message
Console.Write("Hogy hívnak: ");
string userName = Console.ReadLine();
Console.ForegroundColor = ConsoleColor.Red;
Console.WriteLine("Szia " + userName + "!"); //concat
Console.ResetColor();
Console.WriteLine();
Console.BackgroundColor = ConsoleColor.Green;
Console.Write("\tMizu?");
Console.ResetColor();
Console.WriteLine("\nhogyvagy?");
Console.ReadKey();
*/
//elágazások - > Conditions and If Statements
Console.Write("Hány éves vagy: ");
int age = int.Parse(Console.ReadLine());
if (age >= 18)
{
  Console.ForegroundColor = ConsoleColor.Green;
  Console.WriteLine("Mit kérsz?");
}
else
{
  if (age < 16)
  {
    Console.ForegroundColor = ConsoleColor.Yellow;
    Console.WriteLine("Kakaó vagy tej?");
  }
  else
  {
    Console.Write("Hol vagy (A/H):");
    string place = Console.ReadLine();
    if (place == "A" || place == "a")
    {
      Console.WriteLine("Milyen sört kérsz?");
    }
    else
    {
      Console.ForegroundColor = ConsoleColor.Yellow;
      Console.WriteLine("Kakaó vagy tej?");
    }
  }

}

Console.ReadKey();
