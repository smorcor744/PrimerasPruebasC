namespace PrimerasPruebasC;

public class MagicStaff : Weapon
{
    public string Name = MagicStaff;
    private int Damage = 5;
    
    public override void Apply(Character character)
    {
        character.BaseDamage += Damage;

    }
    public void HabilityGenerate(Character character, int mana)
        {
            if (character.MaxManaPoints >= mana)
            {
                double percentage = mana * 0.01;
                Minion minion = new Minion(
                    (int)(character.MaxHitPoints * percentage),
                    (int)(character.TotalDamage * percentage),
                    (int)(character.TotalArmor * percentage),
                    (int)(character.MaxHitPoints * percentage)
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
        Console.WriteLine($"{character.Name} is now not holding the Magic Staff.");

    }

}