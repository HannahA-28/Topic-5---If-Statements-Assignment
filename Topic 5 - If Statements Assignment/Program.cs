namespace Topic_5___If_Statements_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Compass();

            Parking();

            Hurricane();
        }

        public static void Compass()
        {
            int angle;
            Console.WriteLine("Enter an angle between 0 - 360, to see which way it will go on a compass:");
            angle = int.Parse(Console.ReadLine());


            if (angle >= 45 && angle <= 135)
            {
                Console.WriteLine("You are heading East");
            }
            else if (angle >= 135 && angle <= 225)
            {
                Console.WriteLine("You are heading South");
            }
            else if (angle >= 225 && angle <= 315)
            {
                Console.WriteLine("You are heading West");
            }
            else
            {
                Console.WriteLine("You are heading North");
            }

        }

        public static void Parking()
        {
            Console.WriteLine();
            Console.WriteLine("How many minutes were you parked in the garage?");
            if (!double.TryParse(Console.ReadLine(), out double minutes) || minutes < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                return;
            }
            double hours = Math.Ceiling(minutes / 60.0);

            if (hours == 0 && minutes > 0) hours = 1;

            decimal cost = 0m;
            const decimal Min = 4.00m;
            const decimal Hourly = 2.00m;
            const decimal Max = 20.00m;

            Console.WriteLine("PRINTING RECEIPT");
            Thread.Sleep(2000);

            if (hours <= 1)
            {
                cost = Min;
            }
            else
            {
                cost = Min + ((decimal)hours - 1) * Hourly;
            }

            if (cost > Max)
            {
                cost = Max;
            }

            Console.WriteLine();
            Console.WriteLine($"Hours Charged: {hours}");
            Console.WriteLine($"Total Cost:    {cost:C}");
        }

        public static void Hurricane()
        {
            Console.WriteLine();
            string choice;
            Console.WriteLine("Enter a hurricane catagory from 1-5, and I will display the wind speeds: ");
            choice = Console.ReadLine();

            if (choice == "1")
            {
                Console.WriteLine("Catagory 1 speeds are: 74-95 mph, or 64-82 kt, or 119-153 km/hr");
            }
            else if (choice == "2")
            {
                Console.WriteLine("Catagory 2 speeds are: 96-110 mph, or 83-95 kt, or 154-177 km/hr");
            }
            else if (choice == "3")
            {
                Console.WriteLine("Catagory 3 speeds are: 111-130 mph, or 96-113 kt, or 178-209 km/hr");
            }
            else if (choice == "4")
            {
                Console.WriteLine("Catagory 4 speeds are: 131-155 mph, or 114-135 kt, or 210-249 km/hr");
            }
            else if (choice == "5")
            {
                Console.WriteLine("Catagory 5 speeds are greater than: 15mph, or 135 kt, or 249 km/hr");
            }
            else
            {
                Console.WriteLine("Ivalid catagory");
            }
        }
    }
}
