using System;
using System.Collections.Generic;
using System.Text;

namespace AFC.BLL
{
    public class JetFuelCalculation : IFuelCalculation
    {
        private static decimal _usagePerMinute = 58.4m * 2;
        private static decimal _avgSpeed = 748.7m;

        public decimal CalcuateRequiredFuel(Int64 distance)
        {
            return (distance / _avgSpeed * 60 * _usagePerMinute);
        }
    }
}
