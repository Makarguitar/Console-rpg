namespace Console_rpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in your nume");
            string userName = Console.ReadLine();
            Random r = new Random();

            for (int day = 1; day < 6; day++)
            {
                for (int i = 0; i < 5; i++)
                {
                    Console.WriteLine("1 - walk  2 - talk  3 - rest  4 - finish the day");
                    Console.WriteLine("Choose an action");
                    int numOfAction = int.Parse(Console.ReadLine());
                    if (numOfAction == 1)
                    {
                        Console.WriteLine($"{userName} went walking");
                    }
                    else if (numOfAction == 2)
                    {
                        Console.WriteLine($"{userName} started to talk");
                    }
                    else if (numOfAction == 3)
                    {
                        int hour = r.Next(1, 6);
                        Console.WriteLine($"{userName} made a camp and went to a rest for {hour}h");
                    }
                    else if (numOfAction == 4)
                    {
                        Console.WriteLine($"{userName} made a camp and went to sleep");
                        break;
                    }
                    else
                    {
                        Console.WriteLine($"{userName} doesnt know how to do this action");
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
