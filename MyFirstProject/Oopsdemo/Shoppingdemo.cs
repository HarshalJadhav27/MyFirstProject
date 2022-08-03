/*using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Shoppingdemo
    {
        string Purchaseitem;
        int Qty;
        int Price;
        int totalbill;


        public void AcceptDetails(string Purchaseitem, int Qty, int Price)
        {
            this.Purchaseitem = Purchaseitem;
            this.Qty = Qty;
            this.Price = Price;

            if (this.Qty <= 0)
            {
                Console.WriteLine("Error");
            }
            else
            {
                totalbill = this.Getbill();
                this.Display();
            }
        }
         Public int Getbill()
         {
             return Qty * Price;

         }
        
             Public void Display()
             {
                Console.WriteLine("purchase item=" + Purchaseitem);
                Console.WriteLine("Quantity= " + Qty);
                Console.WriteLine("Price= " + Price);
                Console.WriteLine("Total bill=" + totalbill);

                Console.WriteLine();
             }
        static void Main(string[] args)
        {


        }

        }
    }


}*/