namespace PrimerasPruebasC;

class Shield : Protection
{
    private int Armor = 10;
    public override void Apply(Character character)
    {
        character.BaseArmor += Armor;
    }
}