using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Console_rpg
{
    enum TypeOfCharacter
    {
        None, 
        BowMan,
        Warrior,
        Magician
    }

    enum TypeOfBonus
    {
        None,
        Hp,
        Luck,
        Damage
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            string[] typeNames = { "nobody knows", "Bowman", "Warrior", "Magician" };
            string[] bonusNames = { "No bonus", "More Hp", "More Luck", "More Damage" };
            Console.WriteLine("Type in your nume");
            string userName = Console.ReadLine();
            Random r = new Random();
            TypeOfCharacter type = TypeOfCharacter.None;
            TypeOfBonus bonus = TypeOfBonus.None;
            int choice;
            int hp = 100;
            int luck = 30;
            int damage = 30;

            while (type == TypeOfCharacter.None)
            {
                Console.WriteLine("Choose a churucter");
                Console.WriteLine($"1 - {typeNames[(int)TypeOfCharacter.BowMan]}, 2 - {typeNames[(int)TypeOfCharacter.Warrior]}, 3 - {typeNames[(int)TypeOfCharacter.Magician]}");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        type = TypeOfCharacter.BowMan;
                        break;
                    case 2:
                        type = TypeOfCharacter.Warrior;
                        break;
                    case 3:
                        type = TypeOfCharacter.Magician;
                        break;
                    default:
                        Console.WriteLine("this is not a type");
                        break;
                }
            }
            Console.WriteLine($"You chose the {typeNames[(int)type]}");

            while (bonus == TypeOfBonus.None)
            {
                Console.WriteLine("Choose a banus");
                Console.WriteLine($"1 - {bonusNames[(int)TypeOfBonus.Hp]}, 2 - {bonusNames[(int)TypeOfBonus.Luck]}, 3 - {bonusNames[(int)TypeOfBonus.Damage]}");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bonus = TypeOfBonus.Hp;
                        hp *= 2;
                        break;
                    case 2:
                        bonus = TypeOfBonus.Luck;
                        luck *= 2;
                        break;
                    case 3:
                        bonus = TypeOfBonus.Damage;
                        damage *= 2;
                        break;
                    default:
                        Console.WriteLine("this is not a bonus");
                        break;
                }
                Console.WriteLine($"You chose banus: {bonusNames[(int)bonus]}");
                Console.WriteLine($"Your attributes: hp = {hp}, luck = {luck}, damage = {damage}");

            }


            for (int day = 1; day < 6; day++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("1 - walk  2 - talk  3 - rest  4 - finish the day");
                    Console.WriteLine("Choose an action");
                    int numOfAction = int.Parse(Console.ReadLine());
                    switch (numOfAction)
                    {
                        case 1:
                            Console.WriteLine($"{userName} went somewhere");
                            string[] directions = { "west", "east", "south", "north" };
                            for (int j = 0; j < 3; j++)
                            {
                                int km = r.Next(1, 10);
                                int direction = r.Next(0, directions.Length);
                                Console.WriteLine($"{userName} went walking for {km} km to {directions[direction]}");
                            }
                            break;
                        case 2:
                            Console.WriteLine($"{userName} started to talk");
                            /*
                            int hours = 1;
                            while (hours <= 3)
                            {
                                Console.WriteLine($"{userName} talked {hours}h");
                                hours++;
                            }
                            */
                            for (int hours = 1; hours <= 3; hours++)
                            {
                                Console.WriteLine($"{userName} talked {hours}h");
                            }
                            break;
                        case 3:
                            int hour = r.Next(1, 6);
                            Console.WriteLine($"{userName} made a camp and went to a rest for {hour}h");
                            break;
                        case 4:
                            Console.WriteLine($"{userName} made a camp and went to sleep");
                            i = 5;
                            break;
                        default:
                            Console.WriteLine($"{userName} doesnt know how to do this action");
                            break;
                    }
                }
                Console.WriteLine($"{userName} has ended the day: {day} \n");
                Console.WriteLine("to continue the game please press enter, to stop the game please type 0");
                if (Console.ReadLine() == "0")
                {
                    break;
                }
            }
            

                       
        }
    }
}
