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
/* elágazások - > Conditions and If Statements
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

Console.ReadKey(); */
// ciklusok -> loops ->while (előltesztelő), do (hátultesztelő), for 
// fel akarunk venni egy új dolgozót, de nem akarunk nyugdíjasokat vagy diákokat,
// legyen IQ-ja is. (Gondolunk egy számra)
// Határérték (legalább 10-ből)
//irassuk ki hány próbálkozás után találtuk ki csillagokkal.

Console.Write("Hány éves vagy?");
int age = int.Parse(Console.ReadLine());
while (age < 18 || age > 65)
{
  Console.Write("Sajnos nem te vagy a mi emberünk!\nJöhet a következő!\nHány éves vagy?");
  age = int.Parse(Console.ReadLine());
}

Random random = new Random();
int number = random.Next(1, 101);
Console.WriteLine(number);
Console.WriteLine("Gondoltunk egy számra, találd ki!");
int tip;
int tipCounter = 0;
do
{
  Console.Write("Kérünk egy tippet (1-100): ");
  tip = int.Parse(Console.ReadLine());
  tipCounter++;
  if (tip > number)
  {
    Console.WriteLine("Nagyra gondoltál!");
  }
  else if (tip < number)
  {
    Console.WriteLine("Kicsire gondoltál");
  }
  else
  {
    Console.WriteLine("Ügyes vagy, kitaláltad!");
  }
} while (tip != number && tipCounter < 5);
if (tip == number) Console.WriteLine("\nÜdv a fedélzeten!"); else Console.WriteLine("\nNem te vagy a mi emberünk!");

Console.Clear();

for (int i = 0; i < tipCounter; i++)
{
  Console.Write("*");
}