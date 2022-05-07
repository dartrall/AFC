using System;
using System.Collections.Generic;
using System.Text;

namespace AFC.BLL
{
    public interface IFuelCalculation
    {
        public decimal CalculateRequiredFuel(Int64 distance);
    }
}
