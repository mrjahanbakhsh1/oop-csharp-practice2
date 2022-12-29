using System;
namespace program
{
    class calculate
    {
        private double x1;
        private double y1;
        private double x2;
        private double y2;

        public double X1
        {
            get{return x1;}
            set{x1 = value;}
        }

        public double Y1
        {
            get{return y1;}
            set{y1 = value;}
        }

        public double X2
        {
            get{return x2;}
            set{x2 = value;}
        }

        public double Y2
        {
            get{return y2;}
            set{y2 = value;}
        }

        // destructor 
        public void myCalc(){}

        // constructor
        public void myCalc(double X1, double Y1, double X2, double Y2) {
            x1 = X1;
            y1 = Y1;
            x2 = X2;
            y2 = Y2;
        }

        // main method for calculate length of line
        public double lineLength() {
            double power2 = Math.Pow((x2-x1), 2) + Math.Pow((y2-y1), 2);
            double length = Math.Sqrt(power2);

            return length;
        }

    }

    class mainProgram 
    {
        public static void Main()
        {
            Console.WriteLine("Enter Coordinates : (x1, y1) And (x2, y2) ");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());

            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());

            calculate calc = new calculate();
            calc.myCalc(x1, y1, x2, y2);
            Console.WriteLine("Length is : " + calc.lineLength());
        }
    }
}