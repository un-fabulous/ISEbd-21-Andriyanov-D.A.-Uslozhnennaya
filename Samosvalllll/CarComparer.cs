using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samosvalllll
{
    class CarComparer : IComparer<Vehicle>
    {
        public int Compare(Vehicle x, Vehicle y)
        {
            if (x is Samosval && y is Samosval)
            {
                return ComparerSamosval((Samosval)x, (Samosval)y);
            }
            if (x is Samosval && y is Gruzovik)
            {
                return -1;
            }
            if (x is Gruzovik && y is Samosval)
            {
                return 1;
            }
            if (x is Gruzovik && y is Gruzovik)
            {
                return ComparerGruzovik((Gruzovik)x, (Gruzovik)y);
            }
            return 0;
        }

        private int ComparerGruzovik(Gruzovik x, Gruzovik y)
        {
            if (x.MaxSpeed != y.MaxSpeed)
            {
                return x.MaxSpeed.CompareTo(y.MaxSpeed);
            }
            if (x.Weight != y.Weight)
            {
                return x.Weight.CompareTo(y.Weight);
            }
            if (x.MainColor != y.MainColor)
            {
                return x.MainColor.Name.CompareTo(y.MainColor.Name);
            }
            return 0;
        }

        private int ComparerSamosval(Samosval x, Samosval y)
        {
            var res = ComparerGruzovik(x, y);
            if (res != 0)
            {
                return res;
            }
            if (x.DopColor != y.DopColor)
            {
                return x.DopColor.Name.CompareTo(y.DopColor.Name);
            }
            if (x.Support != y.Support)
            {
                return x.Support.CompareTo(y.Support);
            }
            if (x.Carcass != y.Carcass)
            {
                return x.Carcass.CompareTo(y.Carcass);
            }
            if (x.Wheels != y.Wheels)
            {
                return x.Wheels.CompareTo(y.Wheels);
            }
            if (x.WheelsOrnament != y.WheelsOrnament)
            {
                return x.WheelsOrnament.CompareTo(y.WheelsOrnament);
            }
            return 0;
        }
    }
}
