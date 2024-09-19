namespace PrimerasPruebasC;

public class Program
{
    static void Main()
    {
        Character myCharacter = new Character()
        {
            Name = "Harry Potter",
            MaxHitPoints = 100,
            BaseDamage = 10,
            BaseArmor = 5
        };
        Console.WriteLine($"Daño del ataque: {myCharacter.Attack()}");

    }
}