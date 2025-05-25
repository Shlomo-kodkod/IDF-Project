using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    public class StrikeExecution
    {
        public static DateTime GetCurrentTime()
        {
            DateTime currentTime = DateTime.Now;
            return currentTime;
        }

        public static StrikeOptions ChoseAttackWeapon(Terrorist terrorist)
        {

        }


        public static bool IsValidName(string name)
        {
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
            Console.WriteLine("Enter your name: ");
            string Name = Console.ReadLine();
            return Name;
        }
    }
}
