namespace PrimerasPruebasC;

public class Minion
{
    public int MaxLife;
    public int Damage;
    public int Armor;
    public int Life;

    public Minion(int maxLife, int damage, int armor)
    {
        Life = maxLife;
        Damage = damage;
        Armor = armor;

    }

    public int Attack()
    {
        return Damage;
    }
    
    public void RecivedDamage(int damage)
    {
        Life -= damage - Armor;
        Console.WriteLine($"Your Minion has received {damage} of damage and has {Life} of lifePoints.");

    }
}