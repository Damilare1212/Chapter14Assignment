using System;

namespace Chapter_14_Definng_classes
{
    public class Batery
    {
         public int    Model  {get;set;}
        public int    Idletime  {get;set;}
        public int HoursTalk  {get;set;}
        private const string Colour = "Black";

        public Batery(int model, int idletime,int hourstalk,string colour)
        {
            Model = model;
            Idletime = idletime;
            HoursTalk = hourstalk;

        }
            public void TestClassBttery()
            {
                Batery bc = new Batery(15679,5678,052302,Batery.Colour);


                Console.WriteLine($"your batery has a model of {bc.Model} with a idletime of {bc.Idletime} it has a colour {Batery.Colour} and a hours talk of {bc.HoursTalk}");
            }

    }
}