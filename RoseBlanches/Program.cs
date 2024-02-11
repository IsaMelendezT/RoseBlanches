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
            double moneyReceived = 800;
            double booksSupplies;
            double otherPurchases;
            int coffees;
            int flashComputer;
            int subwayTickets;
            double bouquet = 0;

            booksSupplies = moneyReceived * 3 / 4;

            otherPurchases = (moneyReceived - booksSupplies) / 3;

            coffees = (int)otherPurchases / 2;
            bouquet += otherPurchases % 2;

            subwayTickets = (int)otherPurchases / 3;
            bouquet += otherPurchases % 3;

            flashComputer = (int)otherPurchases / 4;
            bouquet += otherPurchases % 4;
            bouquet = (int)bouquet;

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
