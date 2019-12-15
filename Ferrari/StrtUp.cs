using System;

namespace Ferrari
{
    public class StrtUp
    {
        static void Main(string[] args)
        {           
            string driversName = Console.ReadLine();
            Ferrari ferrari = new Ferrari(driversName);

            Console.WriteLine(ferrari);
        }
    }
}
