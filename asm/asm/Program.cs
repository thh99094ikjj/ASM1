using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asm
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name;
            string CustomerType;
            int lastmonth;
            int thismonth;
            

            Console.WriteLine("Enter customer name: "); ;
            name = Console.ReadLine();

            Console.WriteLine("Customer Type: ");
            CustomerType = Console.ReadLine();

            Console.WriteLine("Enter last month's water meter reading: ");
            lastmonth = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter this month's water meter reading: ");
            thismonth = int.Parse(Console.ReadLine());

            Console.WriteLine("the number of people in the household: ");
            int numberofpeople = int.Parse(Console.ReadLine());

            double waterConsumption = thismonth - lastmonth;

            double consumptionPerPerson = waterConsumption / numberofpeople;
            Console.WriteLine("Consume: " + consumptionPerPerson + " M3");

            double priceM3;
            double EnviromentFee;
            double VAT;
            double totalPrice;

            if (CustomerType  == "Household customer")
            {
                if (consumptionPerPerson >= 0 && consumptionPerPerson <= 10)
                {
                    priceM3 = 5.973;
                }
                else if (consumptionPerPerson > 10 && consumptionPerPerson <= 20)
                {
                    priceM3 = 7.052;
                }
                else if (consumptionPerPerson > 20 && consumptionPerPerson <= 30)
                {
                    priceM3 = 8.699;
                }
                else
                {
                    priceM3 = 15.929;
                }
            }
            else if (CustomerType  == "Administrative agency, public services")
            {
                priceM3 = 9.955;
            }
            else if (CustomerType  == "Production units")
            {
                priceM3 = 11.615;
            }
            else if (CustomerType  == "Business services")
            {
                priceM3 = 22.068;
            }
            else
            {
                Console.WriteLine("Invalid customer type!");
                return;
            }

            EnviromentFee = consumptionPerPerson * priceM3 * 0.1;
            VAT = consumptionPerPerson * priceM3 * 0.1;
            totalPrice = consumptionPerPerson * priceM3 + EnviromentFee + VAT;
            Console.WriteLine($"Total price : " + totalPrice + " VND");

            Console.ReadKey();
        }
    }
}
