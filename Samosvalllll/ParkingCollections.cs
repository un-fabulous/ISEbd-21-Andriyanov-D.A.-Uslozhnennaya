using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samosvalllll
{
    class ParkingCollection
    {
        readonly Dictionary<string, Parking<Vehicle, EmblemCircle>> parkingStages;

        public List<string> Keys => parkingStages.Keys.ToList();

        private readonly int pictureWidth;

        private readonly int pictureHeight;

        public ParkingCollection(int pictureWidth, int pictureHeight)
        {
            parkingStages = new Dictionary<string, Parking<Vehicle, EmblemCircle>>();
            this.pictureWidth = pictureWidth;
            this.pictureHeight = pictureHeight;
        }
        public void AddParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                return;
            }
            parkingStages.Add(name, new Parking<Vehicle, EmblemCircle>(pictureWidth, pictureHeight));
        }
        public void DelParking(string name)
        {
            if (parkingStages.ContainsKey(name))
            {
                parkingStages.Remove(name);
            }
        }

        public Parking<Vehicle, EmblemCircle> this[string ind]
        {
            get
            {
                if (parkingStages.ContainsKey(ind))
                {
                    return parkingStages[ind];
                }
                else
                    return null;
            }
        }
        public Vehicle this[string key, int ind]
        {
            get
            {
                if (parkingStages.ContainsKey(key) && ind >= 0)
                {
                    return parkingStages[key][ind];
                }
                return null;
            }
        }
    }
}

