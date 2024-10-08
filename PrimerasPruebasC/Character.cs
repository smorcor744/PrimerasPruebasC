using System.Reflection;
using PrimerasPruebasC;

public class Character( string Name)
{
    public int MaxHitPoints = 100;
    public int BaseDamage = 10;
    public int TotalDamage;
    public int BaseArmor ;
    public int TotalArmor ;
    public int ActualLife ;
    public int MaxManaPoints = 100;
    public int BaseMana;
    private List<Item> _inventory;
    
    public int Attack(int damage){
        TotalDamage += damage + BaseDamage;
        return TotalDamage;
    }

    public int Defense(Protection item)
    {
        return BaseArmor + item.Armor;
    }

    public void Heal(int life)
    {
        if (life +ActualLife > MaxHitPoints)
        {
            ActualLife = MaxHitPoints;
        }
        else
        {
            ActualLife += life;
        }
    }

    public void RecivedDamage(int damage)
    {
        ActualLife -= damage -BaseDamage;
    }
    


}