using System;

namespace Chapter_14_Definng_classes
{
    public class GSM
    {
         public string Model {get;set;}
        public string Manufacturer  {get;set;}
        public int   Price  {get;set;}
        public string Owner  {get;set;}
        private static string Nokia95 {get; set;}
        public  const string Colour = "Tomato Green";
        public const string phonename = "Samsung9t23Glaxy";
        


        public GSM (string model,string manufacturer,int price, string owner, string colour,string phonename)
        {
            Manufacturer = manufacturer;
            Model = model;
            Price = price;
            Owner = owner;
            
            
        }

        public void TestClassGsm()
        {
            GSM gc = new GSM( "itel Woop654", "Apple",10000,"MAyd",GSM.Colour,GSM.phonename);
           
            Console.WriteLine($"your phone model is {gc.Model} the manufacture is {gc.Manufacturer} the price is {gc.Price} it has a {GSM.Colour} colour and its name is {GSM.phonename}");

        }
    }
}