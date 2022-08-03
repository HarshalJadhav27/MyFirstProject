using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class Bankdemo
    {
        long accountno;
        string customername;
        int balance;
        int totalb;

        public void Acceptdetails(long accountno, string customername,int balance)
        {
            this.accountno = accountno;
            this.customername = customername;
            this.balance = balance;

        }
        public void Display()
        {
            Console.WriteLine("Account No=" + accountno);
            Console.WriteLine("Customer Name=" + customername);
            Console.WriteLine("Balance=" + balance);

        }
        public void Amountw()
        {
            Console.WriteLine("Enter the Withdraw amount");
            int W = int.Parse(Console.ReadLine());
            if(balance<=W)
            {
                Console.WriteLine("Error Massege");
            }
            else
            {
                totalb = balance - W;
                Console.WriteLine("Total Balance="+totalb);
            }
        }
        public void Deposite()
        {
            Console.WriteLine("Enter amount");
            int D = int.Parse(Console.ReadLine());

            totalb = balance + D;
            Console.WriteLine("Total Balance="+totalb);
        }
        static void Main(string[] args)
        {
            Bankdemo b = new Bankdemo();
            b.Acceptdetails(41325, "Harsh", 50000);
            b.Display();
            b.Amountw();
            b.Deposite();
        }
    }
}
