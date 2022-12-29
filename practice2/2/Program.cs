using System;
namespace program
{
    class calculate
    {
        private double yard;
        private double meterToYard = 1.196; // or 1.093 meter

        public double Yard
        {
            get{return yard;}
            set{yard = value;}
        }

        // or we can use canstructor

        public double convertToMeter() {
            return (yard / meterToYard); 
        }
    }

    class mainProgram 
    {
        public static void Main()
        {
            Console.WriteLine("Enter Yard : ");
            double yard = Convert.ToDouble(Console.ReadLine());

            calculate calc = new calculate();
            calc.Yard = yard;
            double yardTometer = calc.convertToMeter();
            Console.WriteLine(yardTometer + " Meter");
        }
    }
}