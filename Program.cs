using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Console_rpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in your nume");
            string userName = Console.ReadLine();
            Random r = new Random();
            string type = "";
            string bonus = "";
            int choice;
            int hp = 100;
            int luck = 30;
            int damage = 30;

            while (type == "")
            {
                Console.WriteLine("Choose a churucter");
                Console.WriteLine("1 - Bow Man, 2 - Warrior, 3 - Magician,");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        type = "bow man";
                        break;
                    case 2:
                        type = "warrior";
                        break;
                    case 3:
                        type = "magician";
                        break;
                    default:
                        Console.WriteLine("this is not a type");
                        break;
                }
            }
            Console.WriteLine($"You chose the {type}");

            while (bonus == "")
            {
                Console.WriteLine("Choose a banus");
                Console.WriteLine("1 - more hp, 2 - more luck, 3 - more damage");
                choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        bonus = "more hp";
                        hp *= 2;
                        break;
                    case 2:
                        bonus = "more luck";
                        luck *= 2;
                        break;
                    case 3:
                        bonus = "more damage";
                        damage *= 2;
                        break;
                    default:
                        Console.WriteLine("this is not a bonus");
                        break;
                }
                Console.WriteLine($"You chose banus: {bonus}");
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
                            Console.WriteLine($"{userName} went walking");
                            break;
                        case 2:
                            Console.WriteLine($"{userName} started to talk");
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
