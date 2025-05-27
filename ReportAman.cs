using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    public class ReportAman
    {
        private Terrorist terroristDada;
        private string lastLocation;
        private DateTime timeStemp;

        public ReportAman(Terrorist terroristDada, string leastLocation, DateTime timeStemp)
        {
            this.terroristDada = terroristDada;
            this.lastLocation = leastLocation;
            this.timeStemp = timeStemp;
        }   

        public void UpdateLocation(string lastLocation, DateTime timeStemp)
        {
            this.lastLocation = lastLocation;
            this.timeStemp = timeStemp;
        }

        public Terrorist GetTerrorist()
        {
            return this.terroristDada;
        }

        public string GetLastLocation()
        {
            return this.lastLocation;
        }

        public string ToString()
        {
            return $"{terroristDada.ToString()}\n {lastLocation}\n {timeStemp}\n";
        }
    }
}
