namespace PrimerasPruebasC;

public class FightManager(Character myCharacter, Character enemy)
{

    
    private int Randomizator(int min, int max)
    {
        Random random = new Random();
        int randomNumber = random.Next(min, max);
        return randomNumber;
    }
    
    
    private bool EnemyIQ()
    {
        if (enemy.ActualLife <= 20)
            {
                enemy.Heal(Randomizator(9, 19));
                return false; 
            }
            else
            {
                return true; 
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
                bool accion = EnemyIQ();
                
                if (accion == true)
                {
                    myCharacter.RecivedDamage(enemy.TotalDamage);
                }
                
                Console.WriteLine("Choose an action:");
                Console.WriteLine("1. Attack");
                Console.WriteLine("2. Heal");
                
                string userInput = Console.ReadLine();
                
                switch (userInput)
                {
                    case "1":
                    enemy.RecivedDamage(myCharacter.TotalDamage);
                    break;
                    case "2":
                    myCharacter.Heal(Randomizator(9,17));
                    break;
                    default:
                    Console.WriteLine("Invalid choice. Please choose 1 or 2.");
                    break;
                }

            }
            
        }
    }
}