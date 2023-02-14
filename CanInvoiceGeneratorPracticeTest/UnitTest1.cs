using CabInvoiceGeneratorPractice;

namespace CanInvoiceGeneratorPracticeTest
{
    public class Tests
    {
        InvoiceGenerator invoiceGenerator = null;

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
    }
}