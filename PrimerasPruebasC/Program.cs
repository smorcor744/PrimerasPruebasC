namespace PrimerasPruebasC;

public class Program
    {
        static void Main(string[] args)
        {
            Character myCharacter = new Character("Harry Potter")
            {
                MaxHitPoints = 100,
                BaseDamage = 10,
                BaseArmor = 5
            };

            MagicStaff myMagicStaff = new MagicStaff();

            myCharacter.Equip(myMagicStaff);
            Console.WriteLine($"{myCharacter.Name} has {myCharacter.BaseDamage} base damage after equipping the Magic Staff.");

            myMagicStaff.HabilityGenerate(myCharacter, 50);

            myCharacter.Unequip(myMagicStaff);
            Console.WriteLine($"{myCharacter.Name} has {myCharacter.BaseDamage} base damage after unequipping the Magic Staff.");
        }
    }