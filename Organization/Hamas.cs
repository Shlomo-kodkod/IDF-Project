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
        
/// <summary>
/// Add a terrorist to the Hamas list.
/// </summary>
/// <param name="newTerrorist">Terrorist</param>
        public void AddStrikOption(Terrorist newTerrorist)
        {
            this.TerroristList.Add(newTerrorist);

        }


/// <summary>
        /// Remove a terrorist from the Hamas list.
        /// </summary>
        /// <param name="newTerrorist">Terrorist</param>
        public void RemoveStrikOption(Terrorist currentTerrorist)
        {
            this.TerroristList.Remove(currentTerrorist);
        }

/// <summary>
/// Returns a list of all terrorists who are currently alive from Hamas’s internal list.
/// </summary>
/// <returns>A list whit terrorist</returns>
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

/// <summary>
/// Searches for a terrorist by ID and returns them if found.
/// If not found, returns null.
/// </summary>
/// <param name="id">The ID of the terrorist to search for.</param>
/// <returns>The terrorist that was found.</returns>
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

/// <summary>
/// Checks whether a terrorist with the given ID exists in the Hamas list.
/// </summary>
/// <param name="terroristId">The ID of the terrorist to check for.</param>
/// <returns>True if found, otherwise false.</returns>
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
