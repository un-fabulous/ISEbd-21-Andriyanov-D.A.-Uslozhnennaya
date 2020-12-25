using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samosvalllll
{
    public class CarNotFoundException : Exception
    {
        public CarNotFoundException(int i) : base("Не найдена машина по месту " + i)
        { }
    }
}
