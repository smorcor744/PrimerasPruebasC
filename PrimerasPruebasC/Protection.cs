namespace PrimerasPruebasC;

public abstract class Protection : Item
{
    public string Name;
    public int Armor;

    public abstract void Apply(Character character);
    public abstract void Desply(Character character);
    
}


