namespace PrimerasPruebasC;

public class FightManager(Character myCharacter, Character enemy)
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
    private void Randomizator(int min, int max)
    {
        Random random = new Random();
        int randomNumber = random.Next(min, max);
        
        return randomNumber
    }
    
    private void EnemyIQ()
    {
        if(enemy.ActualLife <= 20)
        {
            enemy.Heal(Randomizator(9,19))
        } 
        else 
        {
            enemy.Attack(12)
        }
        
    }
    
    public void Fight()
    {
        MagicStaff myMagicStaff = new MagicStaff();
        Axe axe = new Axe();

        myCharacter.Equip(myMagicStaff);
        enemy.Equip(axe);

        while (myCharacter.ActualLife > 0 | enemy.ActualLife > 0)
        {
            if (enemy.Speed >= myCharacter.Speed)
            {
                
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Heal");
                
                string userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "1":
                    Attack();
                    break;
                    case "2":
                    Heal();
                    break;
                    default:
                    Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                    break;
                }

            }
        }
    }
}