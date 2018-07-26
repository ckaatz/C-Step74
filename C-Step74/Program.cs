using System;


namespace C_Step74
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("What is your age?");
            string Num1 = Console.ReadLine();
            int Age = Convert.ToInt32(Num1);
            Console.WriteLine("Have you ever had a DUI?");
            string DUI = Console.ReadLine();
            Console.WriteLine("How many speeding tickets do you have?");
            string Num2 = Console.ReadLine();
            int Tickets = Convert.ToInt32(Num2);
            bool Qualified = (Age > 15 && DUI = "No" && Tickets < 3);
        }
    }
}
