using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    public class DataAnalyzer
    {
        public static Terrorist FindTerroristByReport(List<ReportAman> report)
        {
            return report[0].GetTerrorist();
        }

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

            Console.WriteLine(FindTerroristByReport(currentList));
        }

        public void GetAllStrikeOptions(IDF idf)
        {
            foreach (StrikeOptions strikeOptions in idf.GetToolsList())
            {
                Console.WriteLine(strikeOptions.ToString());
            }
        }
        
        public void GetMostDangerousTerrorist(List<Terrorist> list)
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
            Console.WriteLine(mostDangereous);
        }

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
        private int GetTerroristScore(Terrorist terrorist)
        {
            int score = terrorist.GetRank() * GetWeaponsScore(terrorist);
            return score;
        }
        
        
    }
}