using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    public class Money
    {
        protected int dollars;
        protected int cents;

        public Money(int dollars, int cents)
        {
            this.dollars = dollars;
            this.cents = cents;
            Normalize();
        }

        private void Normalize()
        {
            dollars += cents / 100;
            cents %= 100;
        }

        public void DecreasePrice(int dollars, int cents)
        {
            this.dollars -= dollars;
            this.cents -= cents;
            Normalize();
        }

        public void PrintAmount()
        {
            Console.WriteLine($"Total: ${dollars}.{cents:00}");
        }
    }

    public class Product : Money
    {
        private string name;

        public Product(string name, int dollars, int cents) : base(dollars, cents)
        {
            this.name = name;
        }

        public void DisplayDetails()
        {
            Console.Write($"Product: {name}, ");
            PrintAmount();
        }
    }

}
