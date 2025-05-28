using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    public class StrikeExecution
    {
        private Dictionary<string, string> attackMap;
        public StrikeExecution()
        {
            this.attackMap = new Dictionary<string, string>
            {
                { "building", "F16 Fighter Jet" },
                { "people",  "Zik drone" },
                { "vehicle", "Zik drone" },
                { "open area","M109 Artillery"}
            };
        }

        public static bool IsValidName(string name)
        {
            if (name == "")
            {
                return false;
            }
            foreach(char ch in name)
            {
                if (! char.IsLetter(ch))
                {
                    return false;
                }
            }
            return true;
        }
        public static string GetOfficerName()
        {
            string name = "";
            do
            {
                Console.WriteLine("Enter your name: ");
                name = Console.ReadLine();
            }
            while (!IsValidName(name));
            return name;

        }

        public void MakeStrike(StrikeLog strikeLog ,Hamas hamas, IDF idf, Aman aman)
        {
            int terroristId = GetIdToAttack(hamas);
            Terrorist target = hamas.FindTerroristById(terroristId);
            string LastLocation = aman.GetLastLocation(target);
            StrikeOptions weapon = idf.GetRelevantToolsList(LastLocation)[0];
            weapon.Fire();
            target.ChangeToDead();
            strikeLog.AddStrikeLog(target, weapon, GetOfficerName(),
            aman.GetTerroristReport(target)[(aman.GetTerroristReport(target).Count) - 1], weapon.GetCapacity());
        }

        public int GetId()
        {
            int id;
            Console.WriteLine("Enter terrorist id to attack: ");
            string strId = Console.ReadLine();

            while(! int.TryParse(strId, out _))
            {
                Console.WriteLine("Please enter valid id: ");
                strId = Console.ReadLine();
            }
            return int.Parse(strId);
        }

        public int GetIdToAttack(Hamas hamas)
        {
            int id = 0;
            do
            {
                id = GetId();
            }
            while (!hamas.IsTerroristExsist(id));

            return id;
        }
        
    }
}
