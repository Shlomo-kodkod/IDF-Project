namespace IDF_Project;

public class Aman
{
    private Dictionary<int, List<ReportAman>> dicReport;

    public Aman()
    {
        dicReport = new Dictionary<int, List<ReportAman>>();
    }

/// <summary>
    /// Adds a new report to the terrorist's report list. If the terrorist ID does not exist, creates a new list.
    /// </summary>
    /// <param name="report">The report to add, associated with a specific terrorist.</param>
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

/// <summary>
/// Remove all reports from chosen terrorist from Aman reports dictionary.
/// </summary>
/// <param name="ID">Chosen terrorist ID</param>
    public void RemoveReportsTerrorist(int ID)
    {
        this.dicReport.Remove(ID);
    }

    /// <summary>
    /// Retrieves the list of reports associated with the given terrorist.
    /// </summary>
    /// <param name="terrorist">The terrorist whose reports are to be retrieved.</param>
    /// <returns>A list of reports for the specified terrorist.</returns>
    public List<ReportAman> GetTerroristReport(Terrorist terrorist)
    {
        int currentId = terrorist.GetID();
        return this.dicReport[currentId];
    }

/// <summary>
    /// Gets the last known location of the specified terrorist based on their last report.
    /// </summary>
    /// <param name="terrorist">The terrorist whose last location is received.</param>
    /// <returns>The last known location as a string.</returns>
    public string GetLastLocation(Terrorist terrorist)
    {
        List<ReportAman> terroristReport = this.GetTerroristReport(terrorist);
        int len = terroristReport.Count();
        string lastLocation = terroristReport[len - 1].GetLastLocation();
        return lastLocation;
    }

/// <summary>
    /// Returns the full dictionary of terrorist IDs and their associated reports.
    /// </summary>
    /// <returns>A dictionary mapping terrorist IDs to lists of reports.</returns>
    public Dictionary<int, List<ReportAman>> GetReportDic()
    {
        return this.dicReport;
    }
}