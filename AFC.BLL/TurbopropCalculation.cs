using System;

namespace AFC.BLL
{
    public class TurbopropCalculation : IFuelCalculation<TurbopropCalculation>
    {
        private static decimal _usagePerMinute = 0.62m;
        private static decimal _avgSpeed = 232m;

        public decimal CalculateRequiredFuel(Int64 distance)
        {
            return (distance / _avgSpeed * 60 * _usagePerMinute);
        }

    }
}
