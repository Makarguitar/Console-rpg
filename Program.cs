namespace Console_rpg
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Type in your nume");
            string userName = Console.ReadLine();

            for (int i = 0; i < 10; i++)
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
                    Console.WriteLine($"{userName} made a camp and went to a rest");
                }
                else if (numOfAction == 4)
                {
                    Console.WriteLine($"{userName} made a camp and went to sleep");
                }
                else
                {
                    Console.WriteLine($"{userName} doesnt know how to do this action");
                }
                
            }

                       
        }
    }
}
