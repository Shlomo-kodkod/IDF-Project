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

        public List<Terrorist> GetAliveTerroristList()
        {
            List<Terrorist> aliveTerrorist = new List<Terrorist>();
            foreach (Terrorist terrorist in TerroristList)
            {
                if (terrorist.IsAlive())
                {
                    aliveTerrorist.Add(terrorist);
                }
            }
            return aliveTerrorist;
        }

        public Terrorist FindTerroristById(int id)
        {
            Terrorist result = null;
            foreach(Terrorist terrorist in TerroristList)
            {
                if (terrorist.GetID() == id)
                {
                    result = terrorist;
                }
            }
            return result;
        }

        public bool IsTerroristExsist(int terroristId)
        {
            foreach(Terrorist terrorist in TerroristList)
            {
                if (terrorist.GetID() == terroristId)
                {
                    return true;
                }
            }
            return false;
        }

    }
}
