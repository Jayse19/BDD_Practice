using System;

namespace ClassLibrary1
{
    public class FuelEfficiency
    {
        public float calc_mpg(int miles, int gallons)
        {
            return (float)miles/gallons;
        }
        public Boolean gasHog(int miles, int gallons)
        {
            if(miles <= 100 & gallons >= 10)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        public double gasPoints(int miles, int gallons)
        {
            return (double)(miles * gallons) / (100000);
        }
    }
}
