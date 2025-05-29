using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    public class DataAnalyzer
    {
/// <summary>
        /// Finds the terrorist from the report list.
        /// </summary>
        /// <param name="report">List of Aman reports.</param>
        /// <returns>The terrorist from the report.</returns>
        public static Terrorist FindTerroristByReport(List<ReportAman> report)
        {
            return report[0].GetTerrorist();
        }

/// <summary>
        /// Finds the terrorist with the most reports and prints their info and last location.
        /// </summary>
        /// <param name="terrorists">Dictionary with terrorist ID and their reports.</param>
        public void MostReportedTerorist(Dictionary<int, List<ReportAman>> terrorists)
        {
            int maxReported = 0;
            List<ReportAman> currentList = new List<ReportAman>();
            int currentReportNum = 0;

            foreach (KeyValuePair<int, List<ReportAman>> item in terrorists)
            {
                currentReportNum = item.Value.Count();

                if (currentReportNum > maxReported)
                {
                    maxReported = currentReportNum;
                    currentList = item.Value;
                }
            }

            Console.Write(FindTerroristByReport(currentList));
            Console.WriteLine($"Number of Reports : {maxReported}");
            Console.WriteLine(currentList[(currentList.Count)-1].GetLastLocationToPrint());

        }

/// <summary>
        /// Prints all available strike options in the IDF tools list.
        /// </summary>
        /// <param name="idf">IDF object with strike tools.</param>
        public void GetAllStrikeOptions(IDF idf)
        {
            foreach (StrikeOptions strikeOptions in idf.GetToolsList())
            {
                Console.WriteLine(strikeOptions.ToString());
            }
        }
        
/// <summary>
        /// Finds and prints the most dangerous terrorist based on rank and weapons.
        /// </summary>
        /// <param name="list">List of terrorists to check.</param>
        /// <param name="aman">Aman object used to get reports.</param>
        public void GetMostDangerousTerrorist(List<Terrorist> list,Aman aman)
        {
            Terrorist mostDangereous = null;
            int score = 0;
            foreach (Terrorist terrorist in list)
            {
                int tscore = GetTerroristScore(terrorist);
                if (tscore > score)
                {
                    mostDangereous = terrorist;
                    score = tscore;
                }
            }
            Console.Write(mostDangereous);
            List<ReportAman> reportAman = aman.GetTerroristReport(mostDangereous);
            Console.WriteLine(reportAman[(reportAman.Count)-1].GetLastLocationToPrint());
        }

/// <summary>
        /// Calculates weapon score for a terrorist.
        /// </summary>
        /// <param name="terrorist">The terrorist to score.</param>
        /// <returns>Total score based on weapon types.</returns>
        private int GetWeaponsScore(Terrorist terrorist)
        {
            int score = 0;
            Dictionary<string, int> wepons = new Dictionary<string, int>()
            {
                { "Knife", 1 },
                { "Gun", 2 },
                { "M16", 3 },
                { "AK47", 3 }
            };
            foreach (string wepon in terrorist.GetWeapons())
            {
                score += wepons[wepon];
            }
            return score;
        }

/// <summary>
        /// Calculates total danger score using rank and weapon score.
        /// </summary>
        /// <param name="terrorist">The terrorist to score.</param>
        /// <returns>Final danger score.</returns>
        private int GetTerroristScore(Terrorist terrorist)
        {
            int score = terrorist.GetRank() * GetWeaponsScore(terrorist);
            return score;
        }
    }
}