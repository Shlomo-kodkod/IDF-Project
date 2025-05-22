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
        int ID = report.GetTerroist.GetID;
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
}