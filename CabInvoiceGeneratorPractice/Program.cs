namespace CabInvoiceGeneratorPractice
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Displaying Cab Invoice Generator Program");
            InvoiceGenerator generator = new InvoiceGenerator(RideType.NORMAL);
            Console.WriteLine(generator.CalculateFare(10, 15));

        }
    }
}