namespace IDF_Project;

public class Aman
{
    private Dictionary<int, List<ReportAman>> dicReport;

    public Aman()
    {
        dicReport = new Dictionary<int, List<ReportAman>>();
    }

    public void AddReport(ReportAman report)
    {
        int ID = report.GetTerrorist().GetID();
        {
            if (dicReport.Keys.Contains(ID))
            {
                dicReport[ID].Add(report);
            }
            else
            {
                dicReport[ID] = new List<ReportAman>() { report };
            }
        }
    }

    public List<ReportAman> GetTerroristReport(Terrorist terrorist)
    {
        int currentId = terrorist.GetID();
        return this.dicReport[currentId];
    }

    public string GetLastLocation(Terrorist terrorist)
    {
        List<ReportAman> terroristReport = this.GetTerroristReport(terrorist);
        int len = terroristReport.Count();
        string lastLocation = terroristReport[len - 1].GetLastLocation();
        return lastLocation;
    }

    public Dictionary<int, List<ReportAman>> GetReportDic()
    {
        return this.dicReport;
    }
}