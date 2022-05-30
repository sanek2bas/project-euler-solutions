using System; 

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Enter problem solution number or exit to exit program: ");
                var numberStr = Console.ReadLine();
                if (numberStr == "exit")
                    break;
                int number = 0;
                try
                {
                    number = Convert.ToInt32(numberStr);
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    continue;
                }

                ulong result;
                switch (number)
                {
                    case 1:
                        result = Problem_1.GetResult;
                        break;
                    case 10:
                        result = Problem_10.GetResult;
                        break;
                    default:
                        Console.WriteLine("There is no problem with this number");
                        continue;
                }
                Console.WriteLine(result);
            }
        }
    }
}
