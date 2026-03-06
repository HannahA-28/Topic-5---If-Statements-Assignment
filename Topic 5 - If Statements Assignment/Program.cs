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

        }

        public static void Parking()
        {
            Console.WriteLine("How many minutes were you parked in the garage?");
            if (!double.TryParse(Console.ReadLine(), out double minutes) || minutes < 0)
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
                return;
            }
            double hours = Math.Ceiling(minutes / 60.0);

            if (hours == 0 && minutes > 0) hours = 1;

            decimal cost = 0m;
            const decimal MIN_FEE = 4.00m;
            const decimal HOURLY_RATE = 2.00m;
            const decimal MAX_FEE = 20.00m;

            Console.WriteLine("PRINTING RECEIPT");
            Thread.Sleep(2000);

            if (hours <= 1)
            {
                cost = MIN_FEE;
            }
            else
            {
                cost = MIN_FEE + ((decimal)hours - 1) * HOURLY_RATE;
            }

            if (cost > MAX_FEE)
            {
                cost = MAX_FEE;
            }

            Console.WriteLine();
            Console.WriteLine($"Hours Charged: {hours}");
            Console.WriteLine($"Total Cost:    {cost:C}");
        }

        public static void Hurricane()
        {

        }
    }
}
