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
        public static DateTime GetCurrentTime()
        {
            DateTime currentTime = DateTime.Now;
            return currentTime;
        }

        public string ChoseAttackWeapon(Terrorist terrorist, string location)
        {
            return this.attackMap[location];
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
                return name;
            }
            while (!IsValidName(name));
            
        }
    }
}
