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
        private int ID;
        private int Rank;
        private bool Status;
        private string[] Weapons;

        public Terrorist(string Name, int id, int Rank, bool Status, string[] Weapons)
        {
            this.Name = Name;
            this.ID = id;
            this.Rank = Rank;
            this.Status = Status;
            this.Weapons = Weapons;
        }

        public override string ToString()
        {
            return $"name: {this.Name}\n" +
                   $"ID: {this.ID}\n" +
                   $"Rank: {this.Rank}\n" +
                   $"{(this.IsAlive() ? "Alive" : "Dead")}\n" +
                   $"{this.GetWeaponsString()}";

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

        public string GetWeaponsString()
        {
            return String.Join(" ", this.GetWeapons());
        }

        public int GetID()
            {
                return ID;
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
