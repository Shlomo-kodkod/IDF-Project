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

        public static Terrorist MostReportedTerorist(Dictionary<string, List<ReportAman>> terrorists)
        {
            int maxReported = 0;
            List<ReportAman> currentList = new List<ReportAman>();
            int currentReportNum = 0;

            foreach (KeyValuePair<string, List<ReportAman>> item in terrorists)
            {
                currentReportNum = item.Value.Count();

                if (currentReportNum > maxReported)
                {
                    maxReported = currentReportNum;
                    currentList = item.Value;
                }
            }

            return FindTerroristByReport(currentList);
        }

        public void GetAllStrikeOptions(IDF idf)
        {
            Console.WriteLine(string.Join("\n", idf.GetToolsList()));
        }

        public Terrorist GetMostDangerousTerrorist(List<Terrorist> list)
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
            return mostDangereous;
        }

        private int GetTerroristScore(Terrorist terrorist)
        {
            int score = terrorist.GetRank() * GetWeaponsScore(terrorist);
            return score;
        }

        private int GetTerroristScore(Terrorist terrorist)
        {
            int score = terrorist.GetRank() * terrorist.GetWeapons().Length;
        {
            Console.WriteLine(string.Join("\n", idf.GetToolsList()));
        }
        

        public Terrorist GetMostDangerousTerrorist(List<Terrorist> list)
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
            return mostDangereous;
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
        

    }
}
