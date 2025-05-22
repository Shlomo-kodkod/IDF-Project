using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    public class Hamas : MilitaryOrganization
    {
        protected override int yearOfConstruction { get ; set; }
        protected  override string chiefOfStaff { get ; set; }

        private List<Terrorist> TerroristList; 

        public Hamas(int yearOfConstruction, string chiefOfStaff)
        {
            this.yearOfConstruction = yearOfConstruction;
            this.chiefOfStaff = chiefOfStaff;
            this.TerroristList = new List<Terrorist>(); 
        }

        public void AddStrikOption(Terrorist newTerrorist)
        {
            this.TerroristList.Add(newTerrorist);

        }

        public void RemoveStrikOption(Terrorist currentTerrorist)
        {
            this.TerroristList.Remove(currentTerrorist);
        }

    }
}
