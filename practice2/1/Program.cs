using System;
namespace program
{
    class Time
    {
        private int hours;
        private int minutes;

        public int timeHour
        {
            get{return hours;}
            set{hours = value;}
        }

        public int timeMinutes
        {
            get{return minutes;}
            set{minutes = value;}
        }

        public Time() {}

        public Time(int Hours, int Minutes) {
            if(Hours <= 24 && Minutes <= 59) {
                hours = Hours;
                minutes = Minutes;
            }else {
                Console.WriteLine("Time is not correct!");
            }
        }

        // ** we can check a right time in constructor or in convert function there is no difference here

        public void convert() {
            // if(hours <= 24 && minutes <= 59) { // go to the top commenet ^

                if(hours >= 1 && hours <= 12) {
                    Console.WriteLine("Time is " + hours + ":" + minutes + " AM");
                }else if(hours > 12 && hours <= 24) {
                    hours = hours - 12;
                    Console.WriteLine("Time is " + hours + ":" + minutes + " PM");
                }

            // }else {
                // Console.WriteLine("Time is not correct!");
            // }
        }
    }

    class mainProgram 
    {
        public static void Main()
        {
            Console.WriteLine("Enter Your Time => Hour : Minute ");
            int hours = Convert.ToInt32(Console.ReadLine());
            int minutes = Convert.ToInt32(Console.ReadLine());

            Time myTime = new Time(hours, minutes);
            myTime.convert();
        }
    }
}