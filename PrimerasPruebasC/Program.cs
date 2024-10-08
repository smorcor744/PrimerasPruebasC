namespace PrimerasPruebasC;

public class Program
{
    static void Main(string[] args)
    {
        Character myCharacter = new Character("Harry Potter")
        {
            MaxHitPoints = 100,
            BaseDamage = 10,
            BaseArmor = 5
        };

        MagicStaff myMagicStaff = new MagicStaff();

        myMagicStaff.Apply(myCharacter);
        myMagicStaff.Desply(myCharacter);

        Console.WriteLine($"{myCharacter.Name} now has {myCharacter.BaseDamage} base damage.");

        myMagicStaff.HabilityGenerate(myCharacter, 50);

        Console.WriteLine($"{myCharacter.Name} has {myCharacter.ActualLife} life and {myCharacter.BaseDamage} total damage.");
    }
}