using System;
using System.Collections.Generic;
using System.Text;

namespace CabInvoiceCalculation
{
   public class CabInvoice
    {
        private double fare_kelometer = 10;
        private double fare_minute = 1;
        private double min_fare = 5;
        double kelometer;
        double time;
        public CabInvoice()
        {

        }
        public CabInvoice(double kelometer,double time)
        {
            this.kelometer = kelometer;
            this.time = time;
        }

        public double Fare(double distance,double time)
        {
            
            if(time<1)
            {
                return min_fare;
            }
            return (fare_kelometer*distance + fare_minute*time);
        }
        public static double totalFare(CabInvoice[] rides)
        {
            double fare = 0;
            CabInvoice obj = new CabInvoice();
            foreach(CabInvoice ride in rides)
            {
                fare += obj.Fare(ride.kelometer, ride.time);
            }
            return fare;
        }
    }
}
