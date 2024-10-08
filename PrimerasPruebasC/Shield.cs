namespace PrimerasPruebasC;

public class Shield : Protection
{
    private int Armor = 10;

    public override void Apply(Character character)
    {
        character.BaseArmor += Armor;
    }
    
    public override void Desply(Character character)
        {
            character.BaseArmor -= Armor; // Restablecer la armadura
            Console.WriteLine($"{character.Name} is no longer using the Shield.");
        }    
}