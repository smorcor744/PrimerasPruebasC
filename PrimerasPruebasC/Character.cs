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
    public int ActualMana;
    private List<Item> _inventory = new List<Item>();
    public Item? equipment;



    public Character(string name,int maxlife)
    {
        Name = name;
        MaxHitPoints = maxlife;
        ActualLife = maxlife;        
        ActualMana = MaxManaPoints;
        TotalDamage = BaseDamage;
        TotalArmor = BaseArmor;
        equipment = null;

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

    public void InventoryManager()
    {
        bool sal = false;
        while (sal)
        {
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Destroy Item");
            Console.WriteLine("2. Add Item");
            Console.WriteLine("3. Equip Item");
            Console.WriteLine("4. Unequip Item");
            Console.WriteLine("5. Exit");
            
                
            string userInput = Console.ReadLine();
        
            switch (userInput)
            {
                case "1":
                    int cont = 1;
                    Console.WriteLine("What item do you want to destroy?");
                    foreach (var i in _inventory)
                    {
                        
                        Console.WriteLine($"{cont++}. {i}");
                    }
                    if (int.TryParse(Console.ReadLine(), out int itemIndex) && itemIndex > 0 && itemIndex <= _inventory.Count)
                    {
                        Item itemToDestroy = _inventory[itemIndex - 1];
                        Console.WriteLine($"You have chosen to destroy: {itemToDestroy}");
                        Trow(itemToDestroy);
                    }
                    else
                    {
                        Console.WriteLine("Invalid input. Please enter a valid number.");
                    }

                    break;
                case "2":
                    break;
                case "3":
                    break;
                case "4":
                    break;
                case "5":
                    sal = true;
                    break;
                default:
                    Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                    break;
            }
        }
    }

    public void Equip(Item item)
    {
        if (equipment == null)
        {
            item.Apply(this);
            _inventory.Add(item);
            equipment = item;
            Console.WriteLine($"{Name} has equipped {item.GetType().Name}.");
        }
        else
        {
            Console.WriteLine($"{Name} has already equipped {equipment.GetType().Name}.");
            Console.WriteLine($"{Name} has equipped {item.GetType().Name}.");

        }
    }

    public void Unequip(Item item)
    {
        if (equipment == item)
        {
            item.Desply(this);
            equipment = null;
            Console.WriteLine($"{Name} has unequipped {item.GetType().Name}.");
        }
        else
        {
            Console.WriteLine($"{Name} has not equipped {item.GetType().Name}.");
        }
    }    
    
    public void Trow(Item item)
    {
        if (_inventory.Contains(item))
        {
            _inventory.Remove(item);
            Console.WriteLine($"{Name} destroy {item.GetType().Name}.");
        }
        else
        {
            Console.WriteLine($"{Name} dont have this item {item.GetType().Name}.");
        }
    }

    public List<Item> GetInventory()
    {
        return _inventory;
    }
            
}
