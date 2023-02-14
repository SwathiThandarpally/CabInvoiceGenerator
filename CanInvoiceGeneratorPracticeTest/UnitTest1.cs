using CabInvoiceGeneratorPractice;

namespace CanInvoiceGeneratorPracticeTest
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;
        //TestCase1
        [Test]
        public void GivenProperDistanceAndTimeShouldResturnFare()
        {
            //Arrnge
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            double distance = 2.0;
            int time = 5;
            //Act
            double fare = invoiceGenerator.CalculateFare(distance, time);
            double expected = 25;
            //Asseet
            Assert.AreEqual(expected, fare);
        }
        //TestCase2
        [Test]
        public void GivenMultipleRidesShoulsReturnInvoiceSummary()
        {
            invoiceGenerator = new InvoiceGenerator(RideType.NORMAL);
            Ride[] rides = { new Ride(2.0, 5), new Ride(0.1, 1) };

            InvoiceSummary summary = invoiceGenerator.Calculatefare(rides);
            InvoiceSummary expected = new InvoiceSummary(2, 30.0);

            Assert.AreEqual(expected, summary);

        }
    }
}