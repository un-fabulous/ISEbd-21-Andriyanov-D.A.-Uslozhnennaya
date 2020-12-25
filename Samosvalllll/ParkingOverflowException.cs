using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samosvalllll
{
    class ParkingOverflowException : Exception
    {
        public ParkingOverflowException() : base("В гараже нет свободных мест")
        { }
    }
}
