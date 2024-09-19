using PrimerasPruebasC;

public class Character 
{
    public string Name { get; set; }
    public int MaxHitPoints;
    public int BaseDamage;
    public int BaseArmor;
    private List<Item> _inventory;
    
    public int Attack(){
        return BaseDamage;
    }

    public int Defense()
    {
        return BaseArmor;
    }
    public void Heal(int life){}
    public void RecivedDamage(int damage){}
    

}