using System;
namespace program
{
    class calculate
    {
        private int a;
        private int b;
        private int c;
        private int d;

        public int A
        {
            get{return a;}
            set{a = value;}
        }

        public int B
        {
            get{return b;}
            set{b = value;}
        }

        public int C
        {
            get{return c;}
            set{c = value;}
        }

        public int D
        {
            get{return d;}
            set{d = value;}
        }

        // destructor 
        public void myCalc(){}

        // constructor
        public bool myCalc(int A, int B, int C, int D) {
            if(B != 0 && C != 0) {
                a = A;
                b = B;
                c = C;
                d = D;
                return true;
            }else {
                return false;
            }
        }

        // main method for calculate length of line
        public double sum() {
            double result = (a/b) + (c/d);
            return result;
        }

        public double subtraction() {
            double result = (a/b) - (c/d);
            return result;
        }

        public double multiplication() {
            double result = (a/b) * (c/d);
            return result;
        }

        public double division() {
            double result = (a/b) / (c/d);
            return result;
        }

    }

    class mainProgram 
    {
        public static void Main()
        {
            Console.WriteLine("Enter Coordinates : (a/b) And (c/d) ");
            int a = Convert.ToInt32(Console.ReadLine());
            int b = Convert.ToInt32(Console.ReadLine());

            int c = Convert.ToInt32(Console.ReadLine());
            int d = Convert.ToInt32(Console.ReadLine());

            calculate calc = new calculate();
            bool flag = calc.myCalc(a, b, c, d);
            calc.myCalc(a, b, c, d);

            if(flag) {
                Console.WriteLine("sum : " + calc.sum());
                Console.WriteLine("subtraction : " + calc.subtraction());
                Console.WriteLine("multiplication : " + calc.multiplication());
                Console.WriteLine("division : " + calc.division());
            }else {
                Console.WriteLine("Error!");
            }
        }
    }
}