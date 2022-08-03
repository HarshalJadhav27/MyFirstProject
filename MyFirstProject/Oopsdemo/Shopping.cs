using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Shopping
    {
        string purches_item;
        int qty;
        int price;
        int total_bill;
        
        public void AcceptDetails(string purches_item,int qty,int price)
        {
            this.purches_item = purches_item;
            this.qty = qty;
            this.price = price;

            if (this.qty <= 0)
            {
                Console.WriteLine("Wrong quantity");
            }
            else
            {
                total_bill = this.GetBill();
                this.Display();
            }
        }
        public int GetBill()
        {
            return qty * price;

        }

        public void Display()
        {
            Console.WriteLine("Purches item = " + purches_item);
            Console.WriteLine("Quantity= " + qty);
            Console.WriteLine("price= " + price);
            Console.WriteLine("Total bill= " + total_bill);

            Console.WriteLine("...............Thank you........");

        }
        static void Main(string[] args)
        {
            Shopping s = new Shopping();
            s.AcceptDetails("T-shirt",2, 500);
        }
    }
}
