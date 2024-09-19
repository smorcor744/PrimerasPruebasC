namespace PrimerasPruebasC;

public abstract class Weapon : Item
{
    public string Name;
    public int Damage;
    
    public abstract void Apply(Character character);
}
class Axe : Weapon
{
    public override void Apply(Character character){}
}

class Sword : Weapon
{
    public override void Apply(Character character){}
}