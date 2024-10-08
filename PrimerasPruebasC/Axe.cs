namespace PrimerasPruebasC;

public class Axe : Weapon
{
    private int Damage = 10;

    public override void Apply(Character character)
    {
        character.BaseDamage += Damage;
    }

    public override void Desply(Character character)
    {
        character.BaseDamage -= Damage;
    }
}