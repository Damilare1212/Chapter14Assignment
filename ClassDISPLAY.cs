using System;

namespace Chapter_14_Definng_classes
{
    public class Display
    {
        public int Size  {get;set;}
        public const string Colors = "BlackishBrown";
       

        public Display(int size,string colors)
        {
            Size = size;
        }

        public void TestClassDisplay()
        {
              Display gc = new Display(9,Display.Colors);
           
            Console.WriteLine($"your phone display has the size of  {gc.Size}  and a colour of {Display.Colors}");

        }
    }
}