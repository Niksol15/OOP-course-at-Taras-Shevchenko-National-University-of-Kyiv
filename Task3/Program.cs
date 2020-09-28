using System;
using System.Runtime.InteropServices;

namespace Task3
{
    class Converter
    {
        public Converter(double usd, double euro)
        {
            while(usd == 0 || euro == 0)
            {
                Console.WriteLine("Bad input, try again");
                Console.Write("Input USD course: ");
                usd = Convert.ToDouble(Console.ReadLine());
                Console.Write("Input EURO course: ");
                euro = Convert.ToDouble(Console.ReadLine());
            }
            usd_course = usd;
            euro_course = euro;
        }
        public double ConvertUAHtoUSD(double uah)
        {
            return uah / usd_course;
        }
        public double ConvertUAHtoEURO(double uah)
        {
            return uah / euro_course;
        }

        private double usd_course;
        private double euro_course;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Demonstration of the Task 3\nInput USD course: ");
            double usd = Convert.ToDouble(Console.ReadLine());
            Console.Write("Input EURO course: ");
            double euro = Convert.ToDouble(Console.ReadLine());
            Converter converter = new Converter(usd, euro);
            Console.Write("Input UAH: ");
            double uah = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("is " + Convert.ToString(converter.ConvertUAHtoUSD(uah)) + " USD");
            Console.WriteLine("is " + Convert.ToString(converter.ConvertUAHtoEURO(uah)) + " EURO");
            Console.ReadKey();
        }
    }
}
