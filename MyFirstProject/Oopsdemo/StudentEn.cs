using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Oopsdemo
{
    class StudentEn
    {
        int id;
        string name;
        float percentage;
        bool Placement_stutus;


        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }

        }
        public float Percentage
        {
            get { return percentage; }
            set { percentage = value; }

        }
        public bool Placementstutus
        {
            get { return Placement_stutus; }
            set { Placement_stutus = value; }
        }
        static void Main(string[] args)
        {
            StudentEn S = new StudentEn();
            S.Id = 10;
            S.Name = "Harsh";
            S.Percentage = 90;
            
            S.Placementstutus = true;

            Console.WriteLine(S.Id+" "+S.Name+" "+S.Percentage+" "+S.Placementstutus);
        }
    }
}
