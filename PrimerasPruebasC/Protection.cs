namespace PrimerasPruebasC;

public abstract class Protection : Item
{
    public string Name;
    public int Armor;
    
    public abstract void Apply(Character character);
}

class Shield : Protection
{
    public override void Apply(Character character){}
}

class Helmet : Protection
{
    public override void Apply(Character character){}
}
