using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSingleton
{
    public sealed class Garage
    {
        private static Garage instance = null;
        private static readonly object locker = new object();
        private static List<Voiture> _FlottedVehicle;

        private Garage()
        {   
        }

        private void LoadGarage()
        {
            _FlottedVehicle = new List<Voiture>();
            _FlottedVehicle.Add(new Voiture(1, "Polo"));
            _FlottedVehicle.Add(new Voiture(2, "Focus"));
            _FlottedVehicle.Add(new Voiture(3, "Touran"));
        }

        public static Garage Instance
        {
            get
            {
                lock (locker)
                {
                    if (instance == null)
                    {
                        instance = new Garage();
                        instance.LoadGarage();
                    }
                }
                return instance;
            }
        }

        public Voiture RemoveCarFromGarage()
        {
            Voiture voitureToReturn = null;
            if (_FlottedVehicle.Any())
            {
                voitureToReturn = _FlottedVehicle[0];
                _FlottedVehicle.RemoveAt(0);
            }
            return voitureToReturn;
        }

        public int CountVehicle()
        {
            return _FlottedVehicle.Count();
        }
    }
}
