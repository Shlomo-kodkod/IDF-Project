namespace IDF_Project;

public class Aman
{
    private Dictionary<int, List<ReportAman>> listReport;

    public Aman()
    {
        listReport = new Dictionary<int, List<ReportAman>>();
    }

    public void AddReport(ReportAman report)
    {
        int ID = report.GetTerrorist().GetID();
        {
            if (listReport.Keys.Contains(ID))
            {
                listReport[ID].Add(report);
            }
            else
            {
                listReport[ID] = new List<ReportAman>() { report };
            }
        }
    }

    public List<ReportAman> GetTerroristReport(Terrorist terrorist)
    {
        int currentId = terrorist.GetID();
        return this.listReport[currentId];
    }

    public string GetLastLocation(Terrorist terrorist)
    {
        List<ReportAman> terroristReport = this.GetTerroristReport(terrorist);
        int len = terroristReport.Count();
        string lastLocation = terroristReport[len - 1].GetLastLocation();
        return lastLocation;
    }
}