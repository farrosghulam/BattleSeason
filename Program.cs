string characterName;
string battleNumbers;
string EXP;

Console.WriteLine("Input character's name:");
characterName = Console.ReadLine();

Console.WriteLine("Input the number of battles: ");
battleNumbers = Console.ReadLine();

Console.WriteLine("Input the EXP gained per battle: ");
EXP = Console.ReadLine();

Console.WriteLine("\n----------------------------\n");

for (int i = 1; i <= int.Parse(battleNumbers); i++)
{
    Console.WriteLine($"Battle {i} | EXP gained: {EXP} | Total EXP: {int.Parse(EXP) * i}");
}

Console.WriteLine("\n === BATTLE COMPLETE === ");
Console.WriteLine("Character : " + characterName);
Console.WriteLine("Battles: " + battleNumbers);
Console.WriteLine("Total EXP: " + (int.Parse(EXP) * int.Parse(battleNumbers)));
