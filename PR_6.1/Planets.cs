using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR_6._1
{
    class Planets
    {
        public CapturePlanetSingleton CapturePlanetSingleton1 { get; set; }
        public void BusyPlanet()
        {
            CapturePlanetSingleton1 = CapturePlanetSingleton.GetBusyPlanet();
        }
        public void Reset()
        {
            CapturePlanetSingleton.Reset();
        }
    }
}
