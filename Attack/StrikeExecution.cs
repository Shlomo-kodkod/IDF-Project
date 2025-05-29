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

        /// <summary>
        /// Checks if a name is valid (not empty and only letters).
        /// </summary>
        /// <param name="name">The name to check.</param>
        /// <returns>True if valid, false if not.</returns>
        public static bool IsValidName(string name)
        {
            if (name == "")
            {
                return false;
            }
            foreach (char ch in name)
            {
                if (!char.IsLetter(ch) && ! ch.Equals(' '))
                {
                    return false;
                }
            }
            return true;
        }

/// <summary>
        /// Asks the user to enter a valid name.
        /// </summary>
        /// <returns>The officer's name.</returns>
        public static string GetOfficerName()
        {
            string name = "";
            do
            {
                Console.Write("Enter your name: ");
                name = Console.ReadLine();
            }
            while (!IsValidName(name));
            return name;

        }

/// <summary>
        /// Executes a strike on a terrorist using the first relevant weapon for the last known location.
        /// </summary>
        /// <param name="strikeLog">Strike log to record the action.</param>
        /// <param name="hamas">Hamas object used to find the terrorist.</param>
        /// <param name="idf">IDF object to get weapons.</param>
        /// <param name="aman">Aman object to get reports and locations.</param>
        public void MakeStrike(StrikeLog strikeLog ,Hamas hamas, IDF idf, Aman aman)
        {
            int terroristId = GetIdToAttack(hamas);
            Terrorist target = hamas.FindTerroristById(terroristId);
            string LastLocation = aman.GetLastLocation(target);
            StrikeOptions weapon = idf.GetRelevantToolsList(LastLocation)[0];
            weapon.Fire();
            target.ChangeToDead();
            strikeLog.AddStrikeLog(target, weapon, GetOfficerName(),
            aman.GetTerroristReport(target)[(aman.GetTerroristReport(target).Count) - 1],weapon.GetCapacity());
            aman.RemoveReportsTerrorist(terroristId);
        }

/// <summary>
        /// Asks the user to enter a terrorist ID.
        /// </summary>
        /// <returns>A valid terrorist ID as an integer.</returns>
        public int GetId()
        {
            int id;
            Console.Write("Enter terrorist id to attack: ");
            string strId = Console.ReadLine();

            while(! int.TryParse(strId, out _))
            {
                Console.Write("Please enter valid id: ");
                strId = Console.ReadLine();
            }
            return int.Parse(strId);
        }

/// <summary>
        /// Repeats asking for ID until a known terrorist is found.
        /// </summary>
        /// <param name="hamas">Hamas object to check if terrorist exists.</param>
        /// <returns>A valid terrorist ID.</returns>
        public int GetIdToAttack(Hamas hamas)
        {
            int id = 0;
            id = GetId();
            while (!hamas.IsTerroristExsist(id))
            {
                id = GetId();
            }
            return id;
        }
        
    }
}
