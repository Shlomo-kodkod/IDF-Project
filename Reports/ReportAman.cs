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

/// <summary>
        /// Updates the last known location and timestamp of the report.
        /// </summary>
        public void UpdateLocation(string lastLocation, DateTime timeStemp)
        {
            this.lastLocation = lastLocation;
            this.timeStemp = timeStemp;
        }

/// <summary>
        /// Gets the terrorist associated with this report.
        /// </summary>
        public Terrorist GetTerrorist()
        {
            return this.terroristDada;
        }

/// <summary>
        /// Gets the last known location from the report.
        /// </summary>
        public string GetLastLocation()
        {
            return this.lastLocation;
        }

/// <summary>
        /// Gets the last known location from the report to print.
        /// </summary>
        public string GetLastLocationToPrint()
        {
            string location = "";
            switch (this.lastLocation)
            {
                case "buildings":
                    location="in a building";
                    break;
                case "open areas":
                    location = "in a open areas";
                    break;
                default:
                    location = "on the street";
                    break;
            }

            return "Last location : "+location;
        }

/// <summary>
        /// Gets the timestamp of the last known location.
        /// </summary>
        public DateTime GetLastTimeStemp()
        {
            return timeStemp;
        }

/// <summary>
        /// Returns a string representation of the report.
        /// </summary>
        public string ToString()
        {
            return $"{terroristDada.ToString()}\n {lastLocation}\n {timeStemp}\n";
        }
    }
}
