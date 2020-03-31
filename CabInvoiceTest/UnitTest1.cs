using NUnit.Framework;
using NUnit;
using CabInvoiceCalculation;
using System.Collections.Generic;

namespace CabInvoiceTest
{
    public class Tests
    {
        static string userid = "12345";
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CalCulateFare()
        {
            CabInvoice obj = new CabInvoice();
            double result = obj.Fare(5,15);
            Assert.AreEqual(65, result);
        }

        [Test]
        public void CalCulateTotalFare_OfMultipleRides()
        {          
            CabInvoice[] rides =
            {
                new CabInvoice(5,15),
                new CabInvoice(12,35),
                new CabInvoice(7,23)
            };         
            
            double result = CabInvoice.totalFare(rides);
            Assert.AreEqual(313, result);
        }

        [Test]
        public void Return_PartOf_Rides()
        {
            CabInvoice[] rides =
            {
                new CabInvoice(5,15),
                new CabInvoice(12,35),
                new CabInvoice(7,23)
            };

            CabInvoice obj = new CabInvoice();
            var result = CabInvoice.totalFare(rides);
            
        }
    }
}