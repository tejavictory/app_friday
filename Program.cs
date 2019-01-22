using System;

namespace app_friday
{
    class Program
    {
        static void Main(string[] args)
        {
            int total_watts=0,number,i=0;
            double hrs,kwh=0;
            Console.WriteLine("Electricity bill calculator: ");
            Console.WriteLine("Enter total no. of electrical devices working: ");
            number = Convert.ToInt32(Console.ReadLine());
            for(i=0;i<number;i++){
                total_watts=0;
                Console.WriteLine("\nEnter the power rating of your device no. "+(i+1)+" in watts: ");
                total_watts += Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the total hours of usage per month of device no. "+(i+1)+": ");
                hrs = Convert.ToDouble(Console.ReadLine());
                kwh+=total_watts*hrs/1000;
            }
            Console.WriteLine("To view your electricity usage in Watt-hr enter 1");
            Console.WriteLine("To view your electricity usage in kilo-Watt-hr enter 2");
            Console.WriteLine("To view your electricity usage in Mega-Watt-hr enter 3: ");
            int res = Convert.ToInt32(Console.ReadLine());
            switch (res)
            {
                case 1: Console.WriteLine("You have used "+kwh*1000+" watt-hrs"); break;
                case 2: Console.WriteLine("You have used "+kwh+" kilo-watt-hrs"); break;
                case 3: Console.WriteLine("You have used "+kwh/1000+" mega-watt-hrs"); break;
                default:  Console.WriteLine("You have used "+kwh+" kilo-watt-hrs"); break;
            }

        }
    }
}
