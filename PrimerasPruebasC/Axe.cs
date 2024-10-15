namespace PrimerasPruebasC;

public class Axe : Weapon
{
    private int _damage = 10;

    public override void Apply(Character character)
    {
        character.BaseDamage += _damage;
    }

    public override void Desply(Character character)
    {
        character.BaseDamage -= _damage;
    }
}