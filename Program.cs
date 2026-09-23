

Console.WriteLine("Input character's name:");
string characterName = Console.ReadLine();

Console.WriteLine("Input the number of battles: ");
int battleNumbers = int.Parse(Console.ReadLine());

Console.WriteLine("Input the EXP gained per battle: ");
int EXP = int.Parse(Console.ReadLine());

Console.WriteLine("\n----------------------------\n");

for (int i = 1; i <= battleNumbers; i++)
{
    Console.WriteLine($"Battle {i} | EXP gained: {EXP} | Total EXP: {EXP * i}");
}

Console.WriteLine("\n === BATTLE COMPLETE === ");
Console.WriteLine("Character : " + characterName);
Console.WriteLine("Battles: " + battleNumbers);
Console.WriteLine("Total EXP: " + (EXP * battleNumbers));
