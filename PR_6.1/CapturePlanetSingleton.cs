using System;
using System.Windows.Forms;

namespace PR_6._1
{
    public class CapturePlanetSingleton
    {
        private static CapturePlanetSingleton busyPlanet;
        public bool IsPlanetCaptured { get; private set; }

        private CapturePlanetSingleton(bool isPlanetCaptured)
        {
            IsPlanetCaptured = isPlanetCaptured;
        }

        public static CapturePlanetSingleton GetBusyPlanet()
        {
            if (busyPlanet == null)
            {
                Random random = new Random();
                int rand = random.Next(0, 5);
                if (rand == 0)
                {
                    MessageBox.Show("Эта планета уже захвачена!", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    busyPlanet = new CapturePlanetSingleton(true);
                }
                else
                {
                    busyPlanet = new CapturePlanetSingleton(false);
                }
            }
            return busyPlanet;
        }
        public static void Reset()
        {
            busyPlanet = null;
        }
    }
}
