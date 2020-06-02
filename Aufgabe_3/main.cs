using System;
using System.Data;

namespace Aufgabe3
{
    // So könnte man beginnen ...
    abstract class SmartPhone
    {
        protected string PhoneNumber { get; set; }
        // Hier fehlt noch einiges ...
        public string getOS();
    }

    // Hier starten Sie ...

    class Program
    {
        static void Main(string[] args)
        {
            ApplePhone MyApple = new ApplePhone("0123-2324");
            SamsungPhone MySamsung = new SamsungPhone("0049-3242-234");
        }
    }
}
