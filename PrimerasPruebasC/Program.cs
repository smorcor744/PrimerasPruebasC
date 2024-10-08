namespace PrimerasPruebasC;

public class Program
    {
        static void Main(string[] args)
        {
            Character myCharacter = new Character("Harry Potter")
                        {
                            MaxHitPoints = 100,
                            BaseDamage = 10,
                            BaseArmor = 7,
                            Speed = 10
                        };
            Character enemy = new Character("Voldemort")
                        {
                            MaxHitPoints = 120,
                            BaseDamage = 10,
                            BaseArmor = 5,
                            Speed = 9
                        };
            FightManager fightManager = new FightManager(myCharacter, enemy);
            fightManager.Fight();
          
            
        }
    }