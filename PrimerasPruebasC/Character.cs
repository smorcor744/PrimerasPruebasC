namespace PrimerasPruebasC;

public class Character
{
    public string Name;
    public int MaxHitPoints = 100;
    public int BaseDamage = 10;
    public int TotalDamage;
    public int BaseArmor;
    public int TotalArmor;
    public int ActualLife;
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

    public int Attack(int damage)
    {
        TotalDamage += damage + BaseDamage;
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
        }
        else
        {
            ActualLife += life;
        }
    }

    public void RecivedDamage(int damage)
    {
        ActualLife -= damage - BaseArmor;
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
