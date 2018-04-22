using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ProjEnum
{
    class Program
    {
        static void Main(string[] args)
        {
            string command = Console.ReadLine();
          


        }


       public void SetValue(int mode)
        {
            if (mode == 1)
                Console.WriteLine("set value min");
            else if (mode == 2)
                Console.WriteLine("set value medium");
            if (mode == 3)
                Console.WriteLine("set value max");

        }

        public enum ModeValue
        {
            min,medium,max
        }

        public void SetValue(ModeValue mode)
        {
            if (mode == ModeValue.min)
                Console.WriteLine("set value min");
            else if (mode ==  ModeValue.medium)
                Console.WriteLine("set value medium");
            if (mode == ModeValue.max)
                Console.WriteLine("set value max");
        }


    }
}
