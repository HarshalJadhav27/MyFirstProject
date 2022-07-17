using System;
using System.Collections.Generic;
using System.Text;

namespace MyFirstProject.Basics
{
    class Datatypes
    {
        static void Main()
        {
            byte my_byte = 56; // 1 byte 8 bit// 127 to -128
            sbyte mybyte = -45; //8 bit, 7 bit for value & 1 bit for sign

            Console.WriteLine(my_byte + " " + mybyte);

            short my_shortvalue = 234; //2 byte //32,768 to -32,768
            short my_shortvalue2 = -789;

            int my_value = 45667; //4 byte // 2^31 to 2^-31
            int myvalue = -90877;

            long mylong = 73506598841; // 8 byte // 2^64 to 2^-64
            long mylong2 = -07772254555;

            double mydouble = 89.98; // 8 byte

            float myfloat = 68.78f; // 4 byte

            bool mybool = true;//true or false

            char ch = 'h'; //all keys present in keyboard

            string my_name = "harsh";


        }
    }
}
