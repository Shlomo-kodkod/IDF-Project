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
    }
}
