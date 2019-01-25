using System;

namespace app_friday
{
    class Program
    {
        static void Main(string[] args)
        {
            String name;
            bool business =false;
            char type;
            int total_watts=0,number,i=0;
            double hrs,kwh=0,rate;
            decimal bill;
            Console.WriteLine("Electricity bill calculator: ");
            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();
            if(name==""){
                Console.WriteLine("Please enter your name: ");
                name = Console.ReadLine();
            }
            Console.WriteLine($"Hi {name},\nEnter 'y' if you want to calculate your bill for Business. Else enter any other key.");
            type = Convert.ToChar(Console.ReadLine());
            if(type=='y') business=true;
            if(business){
                rate = 0.20;
            }
            else{
                rate = 0.10;
            }
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
            bill = Convert.ToDecimal(billAmount(kwh, rate));
            Console.WriteLine("Press enter when you are ready to view your bill: ");
            Console.ReadLine();
            Console.WriteLine("***************************************************");
            Console.WriteLine("                 Electricity Bill                  ");
            Console.WriteLine("***************************************************");
            Console.WriteLine("Name: "+name);
            Console.WriteLine("Usage Type: "+(business?"Business":"Household"));
            Console.WriteLine("Total Usage:\t\t\t"+kwh+" kWh");
            Console.WriteLine("***************************************************");
            Console.WriteLine("Total bill amount:\t\t$"+bill);
            Console.WriteLine("***************************************************");
        }

        public static double billAmount(double kwh, double rate){
            return kwh*rate;
        }
    }
}
