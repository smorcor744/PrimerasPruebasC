namespace PrimerasPruebasC;

public class Sword : Weapon
{
    private int Damage = 12;

    public override void Apply(Character character)
    {
        character.BaseDamage += Damage;
    }

    public override void Desply(Character character)
    {
        character.BaseDamage -= Damage;
    }
}