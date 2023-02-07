using System;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tarix yazin");
            string dt1=Console.ReadLine();
            DateTime date1=Convert.ToDateTime(dt1);


            Console.WriteLine("Elave olunan ili ayzin");
            string dt2=Console.ReadLine();
            var date2=Convert.ToInt32(dt2);

            date1= date1.AddYears(date2);
            Console.WriteLine(date1.ToString("dd,mm,yyyy"));
        }
    }
}
