namespace PrimerasPruebasC;

public abstract class Weapon : Item
{
    public string Name;
    private int Damage;
    
    public abstract void Apply(Character character);
    public abstract void Desply(Character character);

}

