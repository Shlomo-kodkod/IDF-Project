using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    public class Aman
    {
        private Terrorist terroristDada;
        private string lastLocation;
        private DateTime timeStemp;

        public Aman(Terrorist terroristDada, string leastLocation, DateTime timeStemp)
        {
            this.terroristDada = terroristDada;
            this.lastLocation = leastLocation;
            this.timeStemp = timeStemp;
        }   

        public void UpdateLocation(DateTime timeStemp)
        {
            this.timeStemp = timeStemp;
        }
    }
}
