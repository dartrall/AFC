using System;
using System.Collections.Generic;
using System.Text;

namespace AFC.BLL
{
    public interface IFuelCalculation<T> where T: class, IFuelCalculation<T>
    {
        public decimal CalculateRequiredFuel(Int64 distance);
    }
}
