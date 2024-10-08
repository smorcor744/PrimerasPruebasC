namespace PrimerasPruebasC;

public class Character
{
    public string Name;
    public int MaxHitPoints;
    public int BaseDamage = 10;
    public int TotalDamage;
    public int BaseArmor;
    public int TotalArmor;
    public int ActualLife;
    public int Speed;
    public int MaxManaPoints = 100;
    public int BaseMana;
    private List<Item> _inventory = new List<Item>();

    public Character(string name)
    {
        Name = name;
        ActualLife = MaxHitPoints;
        TotalDamage = BaseDamage;
        TotalArmor = BaseArmor;
    }

    public int Attack()
    {
        return TotalDamage;
    }

    public int Defense(Protection item)
    {
        return BaseArmor + item.Armor;
    }

    public void Heal(int life)
    {
        if (life + ActualLife > MaxHitPoints)
        {
            ActualLife = MaxHitPoints;
            Console.WriteLine($"{Name} has healed {life} and has {ActualLife} of lifePoints.");

        }
        else
        {
            ActualLife += life;
            Console.WriteLine($"{Name} has healed {life} and has {ActualLife} of lifePoints.");

        }
    }

    public void RecivedDamage(int damage)
    {
        ActualLife -= damage - BaseArmor;
        Console.WriteLine($"{Name} has received {damage} of damage and has {ActualLife} of lifePoints.");

    }
    
    public void Equip(Item item)
    {
        item.Apply(this);
        _inventory.Add(item);
        Console.WriteLine($"{Name} has equipped {item.GetType().Name}.");
    }
    
    public void Unequip(Item item)
    {
        item.Desply(this);
        _inventory.Remove(item);
        Console.WriteLine($"{Name} has unequipped {item.GetType().Name}.");
    }    
            
}
