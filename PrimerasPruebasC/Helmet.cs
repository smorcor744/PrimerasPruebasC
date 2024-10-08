namespace PrimerasPruebasC;

class Helmet : Protection
{
    private int Armor = 9;
    
    public override void Apply(Character character)
    {
        character.BaseArmor += Armor;
    }
}
