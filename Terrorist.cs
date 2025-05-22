using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    public class Terrorist
    {
        private string Name;
        private int Rank;
        private bool Status;
        private string[] Weapons;   

        public Terrorist(string Name, int Rank, bool Status, string[] Weapons)
        {
            this.Name = Name;
            this.Rank = Rank;
            this.Status = Status;
            this.Weapons = Weapons;
        }


        public int GetRank()
        {
            return Rank;
        }

        public bool IsAlive()
        {
            return Status;
        }

        public string[] GetWeapons()
        {
            return Weapons;
        }
        public void ChangeToDead()
        {
            bool currentStatus = this.IsAlive();

            if (currentStatus)
            {
                Status = !Status;
            }
        }

        
    }


}
