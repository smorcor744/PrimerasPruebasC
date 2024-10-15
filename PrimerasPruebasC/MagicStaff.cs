namespace PrimerasPruebasC;

public class MagicStaff : Weapon
{
    public string Name = "Magic Staff";
    public int Damage = 5;

    public override void Apply(Character character)
    {
        character.BaseDamage += Damage;
    }

    public void HabilityGenerate(Character character, int mana)
    {
        if (character.MaxManaPoints >= mana)
        {
            character.ActualMana -= mana;
            double percentage = mana * 0.01;
            Minion minion = new Minion(
                (int)(character.MaxHitPoints * percentage),
                (int)(character.TotalDamage * percentage),
                (int)(character.TotalArmor * percentage)
            );
            Console.WriteLine($"Minion Generated! Stats: MaxLife={minion.MaxLife}, Damage={minion.Damage}, Armor={minion.Armor}, Life={minion.Life}");
        }
        else
        {
            Console.WriteLine("Not enough mana to generate a minion!");
        }
    }

     public override void Desply(Character character)
    {
        character.BaseDamage -= Damage;
        Console.WriteLine($"{character.Name} is no longer using the Magic Staff.");
        
    }
}
