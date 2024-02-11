using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseBlanches
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* Variable Declaration*/
            double moneyReceived = 800;
            double booksSupplies;
            double otherPurchases;
            int coffees;
            int flashComputer;
            int subwayTickets;
            double bouquet = 0;

            // Calculate the amount to buy books and supplies
            booksSupplies = moneyReceived * 3 / 4;

            // Calculate the amount of money to buy other stuff
            otherPurchases = (moneyReceived - booksSupplies) / 3;

            // Calculate the amount of coffes to buy and adding the rest for the bouquet
            coffees = (int)otherPurchases / 2;
            bouquet += otherPurchases % 2;

            // Calculate the amount of subway Tickets and adding the rest for the bouquet
            subwayTickets = (int)otherPurchases / 3;
            bouquet += otherPurchases % 3;

            // Calculate the amount of Flash computer and adding the rest for the bouquet
            flashComputer = (int)otherPurchases / 4;
            bouquet += otherPurchases % 4;
            bouquet = (int)bouquet;

            // Print out results
            Console.WriteLine("How much did you receive money ($)? {0}", moneyReceived);
            Console.WriteLine("");
            Console.WriteLine("Books and Supplies: {0} $", booksSupplies);
            Console.WriteLine("You can then buy: ");
            Console.WriteLine("{0} coffees", coffees);
            Console.WriteLine("");
            Console.WriteLine("{0} Flash Computer Numbers", flashComputer);
            Console.WriteLine("{0} subway Tickets", subwayTickets);
            Console.WriteLine("and you will have {0} dollars for the white roses.", bouquet);


        }
    }
}
