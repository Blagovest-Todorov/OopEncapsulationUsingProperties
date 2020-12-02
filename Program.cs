using System;

namespace _21.OopEncapsulationUsingPropertiesGetSet
{
    public class Bank
    {
        private double balance; // field variable declared
        public double Balance
        {
            get { return balance; }

            set
            {  //validate the value
                if (value < 0)
                {
                    Console.WriteLine("value can not be negative");
                }
                balance = value;
            }
        }

    }

    class BankUser
    {
        public static void Main()
        {
            Bank SBI = new Bank();
            SBI.Balance = 100;   //settign the value = 100 using set property.
            Console.WriteLine(SBI.Balance);// accessing the value of the Object SBT using get property
            SBI.Balance = -50; // here checking the value using set property
            Console.WriteLine(SBI.Balance);
            Console.WriteLine("Press any key to exit");
            Console.ReadKey();
        }
    }
}







