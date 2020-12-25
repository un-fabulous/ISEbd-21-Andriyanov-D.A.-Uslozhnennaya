using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Samosvalllll
{
    class ParkingCollection
    {
        readonly Dictionary<string, Parking<Vehicle, EmblemCircle>> parkingStages;
        public List<string> Keys => parkingStages.Keys.ToList();
        
        private readonly int pictureWidth;

        private readonly int pictureHeight;

        private readonly char separator = ':';

        public void SaveData(string filename)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }
            using (FileStream fs = new FileStream(filename, FileMode.Create))
            {
                using (StreamWriter sw = new StreamWriter(fs))
                {
                    sw.WriteLine($"ParkingCollection");

                    foreach (var level in parkingStages)
                    {
                        sw.WriteLine($"Parking{separator}{level.Key}");

                        ITransport car = null;

                        for (int i = 0; (car = level.Value.GetNext(i)) != null; i++)
                        {
                            if (car != null)
                            {
                                if (car.GetType().Name == "Car")
                                {
                                    sw.Write($"Gruzovik{separator}");
                                }
                                if (car.GetType().Name == "Samosval")
                                {
                                    sw.Write($"Samosval{separator}");
                                }
                                sw.WriteLine(car);
                            }
                        }
                    }
                }
            }
        }

        public void SaveData(string filename, string parkingName)
        {
            if (File.Exists(filename))
            {
                File.Delete(filename);
            }

            if (parkingStages.ContainsKey(parkingName))
            {
                using (FileStream fs = new FileStream(filename, FileMode.Create))
                {
                    using (StreamWriter sw = new StreamWriter(fs))
                    {
                        sw.WriteLine($"OneParking");

                        sw.WriteLine($"Parking{separator}{parkingName}");
                        ITransport car = null;
                        var level = parkingStages[parkingName];

                        for (int i = 0; (car = level[i]) != null; i++)
                        {
                            if (car != null)
                            {
                                if (car.GetType().Name == "Car")
                                {
                                    sw.Write($"Gruzovik{separator}");
                                }
                                if (car.GetType().Name == "Samosval")
                                {
                                    sw.Write($"Samosval{separator}");
                                }
                                sw.WriteLine(car);
                            }
                        }
                    }
                }
            }
            throw new FormatException();
        }

        public void LoadData(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }

            string btf = "";

            using (StreamReader sr = new StreamReader(filename))
            {
                btf = sr.ReadLine();

                if (btf.Contains("ParkingCollection"))
                {
                    parkingStages.Clear();
                }
                else
                {
                    throw new FormatException();
                }

                btf = sr.ReadLine();
                Vehicle car = null;
                string key = string.Empty;

                while (btf != null && btf.Contains("Parking"))
                {
                    if (btf.Contains("Parking"))
                    {
                        key = btf.Split(separator)[1];
                        parkingStages.Add(key, new Parking<Vehicle, EmblemCircle>(pictureWidth, pictureHeight));
                    }

                    btf = sr.ReadLine();

                    while (btf != null && (btf.Contains("Gruzovik") || btf.Contains("Samosval")))
                    {
                        if (btf.Split(separator)[0] == "Gruzovik")
                        {
                            car = new Gruzovik(btf.Split(separator)[1]);
                        }
                        else if (btf.Split(separator)[0] == "Samosval")
                        {
                            car = new Samosval(btf.Split(separator)[1]);
                        }

                        var result = parkingStages[key] + car;

                        if (!result)
                        {
                            throw new NullReferenceException();
                        }

                        btf = sr.ReadLine();
                    }
                }
            }
        }

        public void LoadOneStage(string filename)
        {
            if (!File.Exists(filename))
            {
                throw new FileNotFoundException();
            }
            using (StreamReader sr = new StreamReader(filename))
            {
                string line = sr.ReadLine();
               
                if (!line.Contains("OneParking"))
                {
                    throw new FormatException();
                }
                line = sr.ReadLine();
                Vehicle car = null;
                string key = string.Empty;
                if (line != null && line.Contains("Parking"))
                {
                    key = line.Split(separator)[1];
                    if (parkingStages.ContainsKey(key))
                    {
                        parkingStages[key].ClearOneStage();

                    }
                    else { 
                    parkingStages.Add(key, new Parking<Vehicle, EmblemCircle>(pictureWidth, pictureHeight));
                    }
                    line = sr.ReadLine();
                    while (line != null && (line.Contains("Gruzovik") || line.Contains("Samosval")))
                    {
                        if (line.Split(separator)[0] == "Gruzovik")
                        {
                            car = new Gruzovik(line.Split(separator)[1]);
                        }
                        else if (line.Split(separator)[0] == "Samosval")
                        {
                            car = new Samosval(line.Split(separator)[1]);
                        }
                        var result = parkingStages[key] + car;
                        if (!result)
                        {
                            throw new NullReferenceException();
                        }
                        line = sr.ReadLine();
                    }
                }

                else
                {
                    throw new FormatException();
                }
            }
        }

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

