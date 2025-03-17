using System.ComponentModel;
using System.Reflection.Metadata;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using static System.Net.Mime.MediaTypeNames;

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
        static string[] typeNames = { "nobody knows", "Bowman", "Warrior", "Magician" };
        static string[] bonusNames = { "No bonus", "More Hp", "More Luck", "More Damage" };
        static int choice;
        static List<Character> enemies = new List<Character>();

        static void Main(string[] args)
        {
            PrintTextWithBorder("Hello, my name is bozmh, you will play the hardest game in the wurld and you will rage quite");
            Character user = new Character();
            CustomizeCharacter(user, false);

            Character enemy1 = new Character();
            CustomizeCharacter(enemy1, true);
            enemies.Add(enemy1);
            Character enemy2 = new Character();
            CustomizeCharacter(enemy2, true);
            enemies.Add(enemy2);

            GameLoop(user); 
                       
        }

        static void CustomizeCharacter(Character character, bool isEnemy)
        {
            ChooseName(character, isEnemy);
            ChooseType(character, isEnemy);
            ChooseBonus(character, isEnemy);

            if (isEnemy == false)
            {
                Console.WriteLine($"You chose the {typeNames[(int)character.type]}");
                Console.WriteLine($"You chose banus: {bonusNames[(int)character.bonus]}");
                Console.WriteLine($"Your attributes: hp = {character.hp}, luck = {character.luck}, damage = {character.damage}");
            }
        }
        static void ChooseName(Character character, bool isEnemy)
        {
            if (isEnemy == true)
            {
                string[] names = { "dibilich", "bomzh", "alcogolic", "god ra", "valdimir putin" };
                Random r = new Random();
                int index = r.Next(0, names.Length);
                character.name = names[index];
            }
            else
            {
                Console.WriteLine("Type in your nume");
                character.name = Console.ReadLine();
            }
        }

        static void ChooseType(Character user, bool isEnemy)
        {
            while (user.type == TypeOfCharacter.None)
            {
                if (isEnemy == true)
                {
                    Random r = new Random();
                    choice = r.Next(1, typeNames.Length);
                }
                else
                {
                    Console.WriteLine("Choose a churucter");
                    Console.WriteLine($"1 - {typeNames[(int)TypeOfCharacter.BowMan]}, 2 - {typeNames[(int)TypeOfCharacter.Warrior]}, 3 - {typeNames[(int)TypeOfCharacter.Magician]}");
                    choice = int.Parse(Console.ReadLine()); 
                }

                    switch (choice)
                    {
                        case 1:
                            user.type = TypeOfCharacter.BowMan;
                            break;
                        case 2:
                            user.type = TypeOfCharacter.Warrior;
                            break;
                        case 3:
                            user.type = TypeOfCharacter.Magician;
                            break;
                        default:
                            Console.WriteLine("this is not a type");
                            break;
                    }
            }
        }

        static void ChooseBonus(Character user, bool isEnemy)
        {
            while (user.bonus == TypeOfBonus.None)
            {
                if (isEnemy == true)
                {
                    Random r = new Random();
                    choice = r.Next(1, typeNames.Length);
                }
                else
                {
                    Console.WriteLine("Choose a banus");
                    Console.WriteLine($"1 - {bonusNames[(int)TypeOfBonus.Hp]}, 2 - {bonusNames[(int)TypeOfBonus.Luck]}, 3 - {bonusNames[(int)TypeOfBonus.Damage]}");
                    choice = int.Parse(Console.ReadLine());
                }

                switch (choice)
                {
                    case 1:
                        user.bonus = TypeOfBonus.Hp;
                        user.hp *= 2;
                        break;
                    case 2:
                        user.bonus = TypeOfBonus.Luck;
                        user.luck *= 2;
                        break;
                    case 3:
                        user.bonus = TypeOfBonus.Damage;
                        user.damage *= 2;
                        break;
                    default:
                        Console.WriteLine("this is not a bonus");
                        break;
                }
            }
        } 

        static void PrintTextWithBorder(string text)
        {
            string border = "+";
            string middle = $"| {text} |";
            for (int i = 0; i < text.Length + 2; i++)
            {
                border += "-";
            }
            border += "+";
            Console.WriteLine($"{border}\n{middle}\n{border}");
        }

        static void GameLoop(Character user)
        {
            Random r = new Random();
            for (int day = 1; day < 6; day++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("1 - walk  2 - talk  3 - rest  4 - finish the day 5 - attack");
                    Console.WriteLine("Choose an action");
                    int numOfAction = int.Parse(Console.ReadLine());
                    switch (numOfAction)
                    {
                        case 1:
                            Console.WriteLine($"{user.name} went somewhere");
                            string[] directions = { "west", "east", "south", "north" };
                            for (int j = 0; j < 3; j++)
                            {
                                int km = r.Next(1, 10);
                                int direction = r.Next(0, directions.Length);
                                Console.WriteLine($"{user.name} went walking for {km} km to {directions[direction]}");
                            }
                            break;
                        case 2:
                            Console.WriteLine($"{user.name} started to talk");
                            /*
                            int hours = 1;
                            while (hours <= 3)
                            {
                                Console.WriteLine($"{user.name} talked {hours}h");
                                hours++;
                            }
                            */
                            for (int hours = 1; hours <= 3; hours++)
                            {
                                Console.WriteLine($"{user.name} talked {hours}h");
                            }
                            break;
                        case 3:
                            int hour = r.Next(1, 6);
                            Console.WriteLine($"{user.name} made a camp and went to a rest for {hour}h");
                            break;
                        case 4:
                            Console.WriteLine($"{user.name} made a camp and went to sleep");
                            i = 5;
                            break;
                        case 5:
                            if (user.hp > 0)
                            {
                                if (enemies.Count > 0)
                                {
                                    Battle(user, enemies[0]);
                                }
                                else
                                {
                                    Console.WriteLine("there is no enemies :)");
                                }
                            }
                            else
                            {
                                Console.WriteLine("you are too weak :(");
                            }
                                break;
                        default:
                            Console.WriteLine($"{user.name} doesnt know how to do this action");
                            break;
                    }
                }
                Console.WriteLine($"{user.name} has ended the day: {day} \n");
                Console.WriteLine("to continue the game please press enter, to stop the game please type 0");
                if (Console.ReadLine() == "0")
                {
                    break;
                }
            }
        }

        static void Battle(Character player, Character enemy)
        {
            while (player.hp > 0 && enemy.hp > 0)
            {
                player.Attack(enemy);
                if (enemy.hp > 0)
                {
                    enemy.Attack(player);
                }
            }
            if (enemy.hp <= 0)
            {
                //enemies.RemoveAt(0);
                enemies.Remove(enemy);
            }
        }
    }
}
