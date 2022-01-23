using System;

namespace Chapter_14_Definng_classes
{
    public class call
    {
       public string number { get; set; }
        public DateTime Date { get; set; }
        public DateTime Begin { get; set; }
        public DateTime End { get; set; }

        public void logs(string num)
        {
            number = num;

            Date = DateTime.Now;
            Begin = DateTime.UtcNow;
            End = DateTime.UtcNow;
        }
        public string  List()
        {
            string a = $"{number}   {Date} {Begin} {End}";
            return a;
        }
    



    }
}