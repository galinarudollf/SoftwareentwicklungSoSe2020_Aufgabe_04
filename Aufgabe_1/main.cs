using System;
using System.Data;

namespace Softwareentwicklung
{
    public enum PhoneState { off, on, unknown }
    public enum ConnectionState { connected, offline}

    //Interface SmartPhone    
    interface iSmartPhone
    {
        protected string Phonenumber { get; set; }
        protected PhoneState PhoneState { get; set; }
        protected ConnectionState ConnectionState { get; set; }
        private bool makeACall(string phonenumber);
        public bool receiveCall(string incommingNumber);
        private bool startBrowser();
        public string getOS();
    }
  
    class AppleFeatures
    {
        private string AppleID { get; set; }
        protected void BuyAppFromAppStore(string AppName) 
        {
            // something happens herer
        }
        protected bool RunAppleLocalization() 
        {
            // something happens herer
        }
    }
    abstract class AndroidFeatures
    {
        private string GoogleUserAccount { get; set; }
        public void BuyAppFromPlayStore(string AppName)
        {
            // something happens herer
        }
        protected abstract bool RunVendorSpecificLocalization();
    }

    //Google Class inherits both SmartPhone and Features   
    abstract class AndroidPhone : AndroidFeatures, iSmartPhone
    {
        private readonly string OS = "Android";
        protected string Phonenumber { get; set; }
        protected PhoneState PhoneState { get; set; }
        protected ConnectionState ConnectionState { get; set; }
        bool makeACall(string phonenumber) { return true; }
        public bool receiveCall(string incommingNumber) { return true; }
        private bool startBrowser() { return false; }
        public string getOS() { return OS; }
        protected override bool RunVendorSpecificLocalization() 
        {
            return true;
        }
    }

    //Google Class inherits both SmartPhone and Features   
    class ApplePhone : AppleFeatures, iSmartPhone
    {
        private readonly string OS = "AppleOS";
        protected string Phonenumber { get; set; }
        protected PhoneState PhoneState { get; set; }
        protected ConnectionState ConnectionState { get; set; }
        bool makeACall(string phonenumber) { return true; }
        public bool receiveCall(string incommingNumber) { return true; }
        private bool startBrowser() { return false; }
        public string getOS() { return OS; }
        ApplePhone(string Phonenumber) { }
    }

    class SamsungPhone : AndroidPhone {
        Samsung(string Phonenumber) { }
        protected override bool RunVendorSpecificLocalization()
        {
            return true;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            ApplePhone MyApple = new ApplePhone("0123-2324");
            SamsungPhone MySamsung = new SamsungPhone("0049-3242-234");
        }
    }
}
