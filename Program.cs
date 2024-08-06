using System;

namespace Bin2Dec
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Console Binary Converter in C#\r");
            Console.WriteLine("------------------------\n");
            bool repeater = true;
            while (repeater)
            {
                string Bin = "";
                Console.WriteLine("Insert a Binary Value: ");
                Bin = Console.ReadLine();
                try
                {
                    Console.WriteLine(Convert.ToInt32(Bin, 2).ToString() + "\n");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message + "\n");
                }
            }
        }
    }
}
